using Sistema_Factura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Repository.IRepository
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetClientes();
        Cliente GetCliente(int ClienteId);
        Task<bool> ExisteCliente(string nombre);
        Task<bool> ExisteCliente(int id);
        Task<bool> CrearCliente(Cliente cliente);
        Task<bool> ActualizarCliente(Cliente cliente);
        Task<bool> BorrarCliente(Cliente cliente);
        Task<bool> Guardar();
    }
}
