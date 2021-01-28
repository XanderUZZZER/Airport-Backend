using Airport.Core;
using Airport.DB;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Airport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private IFlightServices _flightServices;

        public FlightsController(IFlightServices flightServices)
        {
            _flightServices = flightServices;
        }

        [HttpGet]
        public IActionResult GetFlights()
        {            
            return Ok(_flightServices.GetFlights());
        }

        [HttpGet("{id}", Name = "GetFlight")]
        public IActionResult GetFlight(int id)
        {
            return Ok(_flightServices.GetFlight(id));
        }

        [HttpPost]
        public IActionResult CreateFlight(Flight flight)
        {
            flight.Arrival = DateTime.Parse(flight.Arrival.ToString());
            flight.Departure = DateTime.Parse(flight.Departure.ToString());

            var newFlight = _flightServices.CreateFlight(flight);
            return CreatedAtRoute("GetFlight", new { newFlight.Id }, newFlight);
        }

        [HttpPut]
        public IActionResult EditFlight([FromBody] Flight flight)
        {
            _flightServices.EditFlight(flight);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFlight(int id)
        {
            _flightServices.DeleteFlight(id);
            return Ok();
        }
    }
}
