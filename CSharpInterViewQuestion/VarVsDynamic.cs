using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
    class VarVsDynamic
    {
        public void varExample()
        {
            var x = "Dinesh";

            int len = x.Length;

            dynamic y = "Dinesh";
            int len2 = y.Length;

            //if i do some wrong like y.length it also complie and run with out any error and will not display the length.


          //  int len1 = y.length;

           // Console.WriteLine(len1);
        }
      

    }
}
