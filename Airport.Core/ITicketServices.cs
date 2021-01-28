using Airport.DB;
using System;
using System.Collections.Generic;

namespace Airport.Core
{
    public interface ITicketServices
    {
        Ticket CreateTicket(Ticket ticket);
        Ticket GetTicket(int id);
        List<Ticket> GetTickets();
        void DeleteTicket(int id);
        void EditTicket(Ticket ticket);
    }
}
