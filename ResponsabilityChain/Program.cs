using ResponsabilityChain.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilityChain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility

            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new Secretary();
            Approver raul = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);
            tammy.SetSuccessor(raul);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 22999.99, "Project X");
            larry.ProcessRequest(p);


            p = new Purchase(2036, 32590.10, "New car");
            larry.ProcessRequest(p);

            p = new Purchase(2037, 91000.00, "Project Almanaq");
            larry.ProcessRequest(p);


            p = new Purchase(5451, 85000250.50, "New house for Raúl");
            larry.ProcessRequest(p);

            // Wait for user

            Console.ReadKey();
        }
    }
}
