using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RodriguezJ_MiPrimeraAPI.Models;
using RodriguezJ_MiPrimeraAPI.Repositorios;
using System.Net;

namespace RodriguezJ_MiPrimeraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClientesRepository _clientesRepository;
        public ClientesController()
        {
            _clientesRepository = new ClientesRepository();
        }
        [HttpGet]
        [Route("List")]
        public IEnumerable<Cliente> ObtenerListadoClientes()
        {
            return _clientesRepository.ObtenerListadoClientes();
        }

        [HttpGet]
        [Route("Details/{Identificacion}")]
        public IActionResult ObtenerInfoClientePorIdentificacion(string Identificacion)
        {
            try
            {
                var cliente = _clientesRepository.ObtenerInfoClientePorIdentificacion(Identificacion);

                return Ok(cliente);

            }
            catch (Exception)
            {
                return StatusCode(403);
            }

        }

        [HttpPost]
        public IActionResult CrearCliente([FromBody]Cliente cliente)
        {
            var guardar = _clientesRepository.CrearCliente(cliente);
            if(guardar)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500);
            }

        }

        [HttpPut]
        public IActionResult ActualizarCliente([FromBody]Cliente cliente)
        {


            var actualizar = _clientesRepository.ActuaizarCliente(cliente);
            if(actualizar)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500);
            }
         }

        [HttpDelete]
        public IActionResult EliminarCliente(string Indentificacion)
        {
            var eliminar = _clientesRepository.EliminarCliente(Indentificacion);
            if (eliminar)
            {
                return Ok();
            }
            else
            {
                return StatusCode(200);
            }
        }

    }
}
