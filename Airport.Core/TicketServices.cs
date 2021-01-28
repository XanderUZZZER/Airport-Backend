using Airport.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Airport.Core
{
    public class TicketServices : ITicketServices
    {
        private AppDbContext _context;

        public TicketServices(AppDbContext context)
        {
            _context = context;
        }

        public Ticket GetTicket(int id)
        {
            return _context.Tickets.First(flt => flt.Id == id);
        }

        public List<Ticket> GetTickets()
        {
            return _context.Tickets.ToList();
        }

        public Ticket CreateTicket(Ticket ticket)
        {
            _context.Add(ticket);
            _context.SaveChanges();

            return ticket;
        }

        public void EditTicket(Ticket ticket)
        {
            var editedTicket = _context.Tickets.First(tkt => tkt.Id == ticket.Id);
            editedTicket.Value = ticket.Value;
            _context.SaveChanges();
        }

        public void DeleteTicket(int id)
        {
            var ticket = _context.Tickets.First(tkt => tkt.Id == id);
            _context.Tickets.Remove(ticket);
            _context.SaveChanges();
        }
    }
}
