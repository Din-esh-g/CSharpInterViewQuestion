using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
    public class Shadowing
    {
        public int PurchaseInvoice { get; set; }

    }
    public class Shadowing2: Shadowing
        {
            //This is the shawodwing 
            public new object PurchaseInvoice { get; set; }
        }
}
