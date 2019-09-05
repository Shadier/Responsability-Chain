using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilityChain.BL
{
    public class Secretary : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 50000.0)
            {
                Console.WriteLine("{0} approved request# {1} ('{2}')",
                  this.GetType().Name, purchase.Number, purchase.Purpose);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}
