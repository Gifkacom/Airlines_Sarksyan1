using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Sarksyan1.Models
{
    public  class Ticket
    {
        public string Price {get; set;}

        public string From {get; set;}

        public string To {get; set;}

        public string TimeStart {get; set;}

        public string TimeWay {get; set;}

        public Ticket(string from, string to, string price, string timeStart, string timeWay)
        {
            this.From = from;
            this.To = to;
            this.Price = price;
            this.TimeStart = timeStart;
            this.TimeWay = timeWay;
        }
    }
}
