using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines_Sarksyan1.Models;

namespace Airlines_Sarksyan1.Classes
{
    public class TicketContext : Ticket 
    {
        public TicketContext(string from, string to, string price, string timeStart, string timeWay) : base(from, to, price, timeStart, timeWay)
        {
        }

        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();
            return allTickets;
        }

    }
}
