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
    public class FlightsController : ControllerBase
    {
        private IAirportServices _airportServices;

        public FlightsController(IAirportServices airportServices)
        {
            _airportServices = airportServices;
        }

        [HttpGet]
        public IActionResult GetFlights()
        {            
            return Ok(_airportServices.GetFlights());
        }

        [HttpGet("{id}", Name = "GetFlight")]
        public IActionResult GetFlight(int id)
        {
            return Ok(_airportServices.GetFlight(id));
        }

        [HttpPost]
        public IActionResult CreateFlight(Flight flight)
        {
            var newFlight = _airportServices.CreateFlight(flight);
            return CreatedAtRoute("GetFlight", new { newFlight.Id }, newFlight);
        }

        [HttpPut]
        public IActionResult EditFlight([FromBody] Flight flight)
        {
            _airportServices.EditFlight(flight);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFlight(int id)
        {
            _airportServices.DeleteFlight(id);
            return Ok();
        }
    }
}
