using Airport.DB;
using System;
using System.Collections.Generic;

namespace Airport.Core
{
    public interface IClientServices
    {
        Client CreateClient(Client client);
        Client GetClient(int id);
        List<Client> GetClients();
        void DeleteClient(int id);
        void EditClient(Client client);
    }
}
