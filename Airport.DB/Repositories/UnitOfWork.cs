using Airport.DB.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.DB.Repositories
{
    class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        private FlightRepository _flights;
        private ClientRepository _clients;
        private TicketRepository _tickets;

        public UnitOfWork(string connectionString)
        {
            _context = new AppDbContext(connectionString);
        }

        public IRepository<Flight> Flights
        {
            get
            {
                if (_flights == null)
                    _flights = new FlightRepository(_context);
                return _flights;
            }
        }

        public IRepository<Client> Client
        {
            get
            {
                if (_clients == null)
                    _clients = new ClientRepository(_context);
                return _clients;
            }
        }

        public IRepository<Ticket> Ticket
        {
            get
            {
                if (_tickets == null)
                    _tickets = new TicketRepository(_context);
                return _tickets;
            }
        }
    }
}
