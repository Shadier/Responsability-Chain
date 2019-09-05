using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilityChain.BL
{
    public class President: Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1} ('{2}')",
                  this.GetType().Name, purchase.Number, purchase.Purpose);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
            else{
                Console.WriteLine(
                  "Request# {0} ('{1}') requires an executive meeting!",
                  purchase.Number, purchase.Purpose);
            }
        }
    }
}
