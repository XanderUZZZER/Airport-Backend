using Airport.DB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.DB.Repositories
{
    class ClientRepository : IRepository<Client>
    {
        private AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public Client Get(int id)
        {
            return _context.Clients.First(clnt => clnt.Id == id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client Create(Client entity)
        {
            _context.Clients.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Edit(Client entity)
        {
            var editedClient = _context.Clients.First(clnt => clnt.Id == entity.Id);
            editedClient.FirstName = entity.FirstName;
            editedClient.LastName = entity.LastName;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var client = _context.Clients.First(clnt => clnt.Id == id);
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }        
    }
}
