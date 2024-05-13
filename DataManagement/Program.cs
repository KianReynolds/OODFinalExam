using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OODFinalExam;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerData db = new CustomerData ("OOD_KianReynolds");

            using (db)
            {
                Customer c1 = new Customer() { Name = "Tom Jones", ContactNumber = "086-123 4567"};
                Customer c2 = new Customer() { Name = "Mary Smith", ContactNumber = "086 546 3214" };
                Customer c3 = new Customer() { Name = "Jo Doyle", ContactNumber = "087 1221 222" };

                
                //Add customers
                db.Customers.Add(c1);
                db.Customers.Add(c2);
                db.Customers.Add(c3);
                
                //save changes
                db.SaveChanges();



            }
        }
    }
}
