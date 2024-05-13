using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODFinalExam
{
    public class Booking
    {
        public int BookingID { get; set; }
        public DateTime BookingsDate { get; set; }
        public int NumberOFParticipants { get; set; }

        

    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }
}
