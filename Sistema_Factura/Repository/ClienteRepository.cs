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
        public bool ActualizarCliente(Cliente cliente)
        {
            _db.Cliente.Update(cliente);
            return Guardar();
        }

        public bool BorrarCliente(Cliente cliente)
        {
            _db.Cliente.Remove(cliente);
            return Guardar();
        }

        public bool CrearCliente(Cliente cliente)
        {
            _db.Cliente.Add(cliente);
            return Guardar();
        }

        public bool ExisteCliente(string nombre)
        {
            //ToLower: Devuelve una copia de esta cadena convertida a minúsculas.
            //Trim: Elimina todos los caracteres de espacios en blanco iniciales y finales de la cadena actual.
            bool valor = _db.Cliente
                          .Any(c => c.NombreCliente.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public bool ExisteCliente(int id)
        {
            return _db.Cliente.Any(c => c.ClienteId == id);
        }

        public Cliente GetCliente(int ClienteId)
        {
            return _db.Cliente.FirstOrDefault(c => c.ClienteId == ClienteId);
        }

        public ICollection<Cliente> GetClientes()
        {
            return _db.Cliente.OrderBy(c => c.NombreCliente).ToList();
        }

        public bool Guardar()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
