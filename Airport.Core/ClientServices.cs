using Airport.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Airport.Core
{
    public class ClientServices : IClientServices
    {
        private AppDbContext _context;

        public ClientServices(AppDbContext context)
        {
            _context = context;
        }

        public Client GetClient(int id)
        {
            return _context.Clients.First(flt => flt.Id == id);
        }

        public List<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Client CreateClient(Client client)
        {
            _context.Add(client);
            _context.SaveChanges();

            return client;
        }

        public void EditClient(Client client)
        {
            var editedClient = _context.Clients.First(clnt => clnt.Id == client.Id);
            editedClient.FirstName = client.FirstName;
            editedClient.LastName = client.LastName;
            _context.SaveChanges();
        }

        public void DeleteClient(int id)
        {
            var client = _context.Clients.First(clnt => clnt.Id == id);
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}
