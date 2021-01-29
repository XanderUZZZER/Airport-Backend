using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.DB.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Flight> Flights { get; }
        IRepository<Client> Client { get; }
        IRepository<Ticket> Ticket { get; }
    }
}
