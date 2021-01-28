using Airport.DB;
using System;
using System.Collections.Generic;

namespace Airport.Core
{
    public interface IFlightServices
    {
        Flight CreateFlight(Flight flight);
        Flight GetFlight(int id);
        List<Flight> GetFlights();
        void DeleteFlight(int id);
        void EditFlight(Flight flight);
    }
}
