$(function () {

    //$("#btnAgregarProducto").click(function () {
        var url = "/TemporalProducto/ProductosAgregados";

        $.get(url).done(function (data) {
            $("#dataTable").append(data);
        }).fail(manejarErrorAjax);
    //});
});












//FUNCIONA, PERO AGREGARLO A VISTA FACTURAS
//@* TESTIN DATA TABLE AJAX *@
//<div class="col-12 border p-3">
//    <table id="DT_Load" class="table table-striped border">
//        <thead>
//            <tr>
//                <th>CODIGO</th>
//                <th>NOMBRE</th>
//                <th>CANTIDAD</th>
//                <th>PRECIO UNITARIO</th>
//                <th>SUBTOTAL</th>
//                <th></th>
//            </tr>
//        </thead>
//    </table>
//</div>



//var dataTable;
//$(document).ready(function () {
//    //alert("hello");
//    dataTable = $('#DT_Load').DataTable({
//        "ajax": {
//            "url": "/TemporalProducto/DataTable",
//            "type": "GET",
//            "datatype": "json"
//        },
//        "columns": [           
//            {
//                "data": "codigoProducto",
//                "width": "10%"
//            },
//            {
//                "data": "nombreProducto",
//                "width": "20%"
//            },
//            {
//                "data": "cantidad_temp",
//                "width": "10%"
//            },
//            {
//                "data": "precioVenta_temp",
//                "width": "10%"
//            },
//            {
//                "data": "subTotal_temp",
//                "width": "10%"
//            },            
//            {
//                "data": "tempProductoId",
//                "width": "10%",
//                "render": function (data) {
//                          return `<div class='text-center'>                    
//                                    <a onclick=Delete('/Product/DeleteByDataApiJson?TempProductoId='+${data}) class='btn btn-danger text-white' style='cursor:pointer'>Delete</a>                       
//                                 </div>`

//                }
//            }

//        ],
//        "language": {
//            "emptyTable": "Not Found Data"
//        },
//        "width": "100%"

//    });
//});

//******CONTROLADOR FUNCIONA DATATABLE CON AJAX************+
//[HttpGet]
//        public async Task < IActionResult > DataTable()
//{
//    //var temAjax = _context.TempProducto.ToListAsync();
//    var productoAjax = (from t in _context.TempProducto
//    join p in _context.Producto
//    on t.ProductoId equals p.ProductoId
//    select new
//        {
//            t.TempProductoId,
//            p.CodigoProducto,
//            p.NombreProducto,
//            t.Cantidad_temp,
//            t.PrecioVenta_temp,
//            t.SubTotal_temp
//        }).ToListAsync();


//    return Json(new { data = await productoAjax });
//}