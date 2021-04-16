using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Factura.DataContext;
using Sistema_Factura.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Controllers
{
    public class ExportarExcelController : Controller
    {
        private readonly Sistema_FacturaContext _context;
        public ExportarExcelController(Sistema_FacturaContext context) => _context = context;
        
        public IActionResult Index()
        {
            return ExportarExcel();
        }

        public IActionResult ExportarExcel()
        {           
            var _selectFactura = _context.Factura.Where(f=>f.EstadoFactura==1).Include(f => f.Cliente).ToList();
            
            using (var workBook = new XLWorkbook())
            {
                var worksheet = workBook.Worksheets.Add("Factura");
                var currentRow = 1;
                //worksheet.Cell(currentRow, 1).Value = "FacturaId";
                worksheet.Cell(currentRow, 1).Value = "FECHA FACTURA";
                worksheet.Cell(currentRow, 2).Value = "CLIENTE";
                worksheet.Cell(currentRow, 3).Value = "NIT";
                worksheet.Cell(currentRow, 4).Value = "TOTAL";

                if (!_selectFactura.Count.Equals(0))
                { 
                    foreach (var emp in _selectFactura)
                    {
                        currentRow++;
                        //worksheet.Cell(currentRow, 1).Value = emp.FacturaId;
                        worksheet.Cell(currentRow, 1).Value = emp.FechaFactura;
                        worksheet.Cell(currentRow, 2).Value = emp.Cliente.NombreCliente;
                        worksheet.Cell(currentRow, 3).Value = emp.Cliente.Nit;
                        worksheet.Cell(currentRow, 4).Value = emp.TotalPrecio;
                    }
                    using (var stream = new MemoryStream())
                    {
                        workBook.SaveAs(stream);
                        var content = stream.ToArray();
                        return File(content,
                            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                            "FacturaInfo.xlsx");
                    }                
                }
            }
            return View();
        }
    }
}
