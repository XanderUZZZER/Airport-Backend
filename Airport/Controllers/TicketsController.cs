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
    public class TicketsController : ControllerBase
    {
        private ITicketServices _ticketServices;

        public TicketsController(ITicketServices ticketServices)
        {
            _ticketServices = ticketServices;
        }

        [HttpGet]
        public IActionResult GetTickets()
        {            
            return Ok(_ticketServices.GetTickets());
        }

        [HttpGet("{id}", Name = "GetTicket")]
        public IActionResult GetTicket(int id)
        {
            return Ok(_ticketServices.GetTicket(id));
        }

        [HttpPost]
        public IActionResult CreateClient(Ticket ticket)
        {
            var newTicket = _ticketServices.CreateTicket(ticket);
            return CreatedAtRoute("GetTicket", new { newTicket.Id }, newTicket);
        }

        [HttpPut]
        public IActionResult EditTicket([FromBody] Ticket ticket)
        {
            _ticketServices.EditTicket(ticket);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTicket(int id)
        {
            _ticketServices.DeleteTicket(id);
            return Ok();
        }
    }
}
