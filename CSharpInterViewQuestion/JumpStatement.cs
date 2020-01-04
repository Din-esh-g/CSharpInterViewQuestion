using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
   public class JumpStatement
    {

        public void gotoMetod(){
            Console.WriteLine(" Goto Starts ");
            goto g;


           // Console.WriteLine("This line cant be added"); this line will be skipped because of the go to is noted to go for g blocks.
        g:
            {
                Console.WriteLine(" This section will be displayed ");
            }
            Console.Read();

        }
    }
}
