using Microsoft.EntityFrameworkCore;
using Sistema_Factura.DataContext;
using Sistema_Factura.Models;
using Sistema_Factura.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        //INYECCION DE DEPENDENCIA DATABASE
        private readonly Sistema_FacturaContext _db;
        public ClienteRepository(Sistema_FacturaContext db)
        {
            _db = db;
        }
        
        //METODO PARA ACUTALIZAR LOS DATOS DEL CLIENTE
        public async Task<bool> ActualizarCliente(Cliente cliente)
        {
             _db.Cliente.Update(cliente);
            return await Guardar();
        }

        //METODO QUE BORRA O DA DE BAJA AL CLIENTE CAMBIANDO SU ESTADO
        public async Task<bool> BorrarCliente(Cliente cliente)
        {
            _db.Cliente.Remove(cliente);
            return await Guardar();
        }

        //METODO PARA CREAR UN REGISTRO NUEVO DE CLIENTE
        public async Task<bool> CrearCliente(Cliente cliente)
        {            
            try
            {
                if(cliente != null)
                {
                    _db.Cliente.Add(cliente);
                    return await Guardar();
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        //METODO DE VERIFICACION SI EXISTE EL CLIENTE POR EL NOMBRE INGRESADO
        public async Task<bool> ExisteCliente(string nit)
        {
            //ToLower: Devuelve una copia de esta cadena convertida a minúsculas.
            //Trim: Elimina todos los caracteres de espacios en blanco iniciales y finales de la cadena actual.
            bool valor = await _db.Cliente
                          .AnyAsync(c => c.Nit.ToLower().Trim() == nit.ToLower().Trim());
            return valor;
        }

        //METODO DE VERIFICACION SI EXISTE EL CLIENTE POR EL ID INGRESADO
        public async Task<bool> ExisteCliente(int id)
        {
            return  await _db.Cliente.AnyAsync(c => c.ClienteId == id);
        }

        //METODO QUE TRAE EL DATO DEL CLIENTE POR EL ID BUSCADO
        public Cliente GetCliente(int ClienteId)
        {
            return _db.Cliente.FirstOrDefault(c => c.ClienteId == ClienteId);
        }

        //METODO QUE TRAE TODO LOS REGISTROS DEL CLIENTES
        public async Task<List<Cliente>> GetClientes()
        {
            var cliente = new List<Cliente>();

            try
            {
                cliente = await _db.Cliente.OrderBy(c => c.NombreCliente).Where(c=>c.Estado==1).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return cliente;
            //return await _db.Cliente.OrderBy(c => c.NombreCliente).ToListAsync();
        }

        //METODO QUE GUARDA LOS DATOS COMPROMETIDOS A LA BASE DE DATOS
        public async Task<bool> Guardar()
        {            
            return await _db.SaveChangesAsync() >= 0 ? true : false;
        }
    }
}
