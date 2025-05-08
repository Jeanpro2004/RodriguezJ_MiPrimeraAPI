using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using RodriguezJ_MiPrimeraAPI.Models;

namespace RodriguezJ_MiPrimeraAPI.Repositorios

{
    public class ClientesRepository
    {
        private CuentaRepository _cuentasRepository;

        public ClientesRepository()
        {
            _cuentasRepository = new CuentaRepository();
        }

        public IEnumerable<Cliente> ObtenerListadoClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente1 = new Cliente
            {
                Identificacion = "123456789",
                Correo = "jeanrodQgmail.com",
                Nombre = "Jean Rodriguez",
                Cuentas = _cuentasRepository.ObtenerListadoCuentasPorCliente("123456789")
            };
            Cliente cliente2 = new Cliente
            {
                Identificacion = "987654321",
                Correo = "pepitoperezgmail.com",
                Nombre = "Pepito Perez",
                Cuentas = _cuentasRepository.ObtenerListadoCuentasPorCliente("987654321")
            };
            clientes.Add(cliente1);
            clientes.Add(cliente2);

            return clientes;

        }
        public Cliente ObtenerInfoClientePorIdentificacion(string Identificacion)
        {
            var clientes = ObtenerListadoClientes();
            Cliente cliente = clientes.First(item => item.Identificacion == Identificacion);
            return cliente;

        }

        public bool CrearCliente(Cliente cliente)
        {
            //Logica
            return true;
        }

        public bool ActuaizarCliente( Cliente cliente)
        {
            //Logica
            return true;

        }
        
        public bool EliminarCliente(string Identificacion)
        {
            //Logica
            return true;
        }
    }
}
