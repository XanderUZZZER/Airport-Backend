using Airport.DB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.DB.Repositories
{
    class FlightRepository : IRepository<Flight>
    {
        private AppDbContext _context;

        public FlightRepository(AppDbContext context)
        {
            _context = context;
        }

        public Flight Get(int id)
        {
            return _context.Flights.First(flight => flight.Id == id);
        }

        public IEnumerable<Flight> GetAll()
        {
            return _context.Flights.ToList();
        }

        public Flight Create(Flight entity)
        {
            _context.Flights.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Edit(Flight entity)
        {
            var editedFlight = _context.Flights.First(flt => flt.Id == entity.Id);
            editedFlight.Arrival = entity.Arrival;
            editedFlight.Departure = entity.Departure;
            editedFlight.Value = entity.Value;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var flight = _context.Flights.First(flt => flt.Id == id);
            _context.Flights.Remove(flight);
            _context.SaveChanges();
        }        
    }
}
