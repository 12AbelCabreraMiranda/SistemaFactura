using Sistema_Factura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Repository.IRepository
{
    public interface IClienteRepository
    {
        ICollection<Cliente> GetClientes();
        Cliente GetCliente(int ClienteId);
        bool ExisteCliente(string nombre);
        bool ExisteCliente(int id);
        bool CrearCliente(Cliente cliente);
        bool ActualizarCliente(Cliente cliente);
        bool BorrarCliente(Cliente cliente);
        bool Guardar();
    }
}
