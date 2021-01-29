using Airport.DB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.DB.Repositories
{
    class TicketRepository : IRepository<Ticket>
    {
        private AppDbContext _context;

        public TicketRepository(AppDbContext context)
        {
            _context = context;
        }

        public Ticket Get(int id)
        {
            return _context.Tickets.First(tckt => tckt.Id == id);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _context.Tickets.ToList();
        }

        public Ticket Create(Ticket entity)
        {
            _context.Tickets.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Edit(Ticket entity)
        {
            var editedTicket = _context.Tickets.First(tckt => tckt.Id == entity.Id);
            editedTicket.Value = entity.Value;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ticket = _context.Tickets.First(tckt => tckt.Id == id);
            _context.Tickets.Remove(ticket);
            _context.SaveChanges();
        }        
    }
}
