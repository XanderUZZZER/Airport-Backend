using Airport.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Airport.Core
{
    public class AirportService : IAirportServices
    {
        private AppDbContext _context;

        public AirportService(AppDbContext context)
        {
            _context = context;
        }

        public Flight GetFlight(int id)
        {
            return _context.Flights.First(flt => flt.Id == id);
        }

        public List<Flight> GetFlights()
        {
            return _context.Flights.ToList();
        }

        public Flight CreateFlight(Flight flight)
        {
            _context.Add(flight);
            _context.SaveChanges();

            return flight;
        }

        public void EditFlight(Flight flight)
        {
            var editedFlight = _context.Flights.First(flt => flt.Id == flight.Id);
            editedFlight.Arrival = flight.Arrival;
            editedFlight.Departure = flight.Departure;
            editedFlight.Value = flight.Value;
            _context.SaveChanges();
        }

        public void DeleteFlight(int id)
        {
            var flight = _context.Flights.First(flt => flt.Id == id);
            _context.Flights.Remove(flight);
            _context.SaveChanges();
        }
    }
}
