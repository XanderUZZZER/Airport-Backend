using Airport.Core;
using Airport.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private IClientServices _clientServices;

        public ClientsController(IClientServices clientServices)
        {
            _clientServices = clientServices;
        }

        [HttpGet]
        public IActionResult GetClients()
        {            
            return Ok(_clientServices.GetClients());
        }

        [HttpGet("{id}", Name = "GetClient")]
        public IActionResult GetClient(int id)
        {
            return Ok(_clientServices.GetClient(id));
        }

        [HttpPost]
        public IActionResult CreateClient(Client client)
        {
            var newClient = _clientServices.CreateClient(client);
            return CreatedAtRoute("GetClient", new { newClient.Id }, newClient);
        }

        [HttpPut]
        public IActionResult EditClient([FromBody] Client client)
        {
            _clientServices.EditClient(client);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClient(int id)
        {
            _clientServices.DeleteClient(id);
            return Ok();
        }
    }
}
