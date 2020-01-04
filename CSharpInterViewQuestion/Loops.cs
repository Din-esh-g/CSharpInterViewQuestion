using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
   public class Loops
    {
        int number = 5;
        public void While()
        {
            while (number <=10)
            {
                Console.WriteLine($"{number}  This is the whileloop");
                number++;
            }
        }

        public void forLoop()
        {
            for(int i = 0; i<=number; i++)
            {
                Console.WriteLine($"{i}This is the number");
            }
        }

        public void infiniteLoop()
        {
            for (; ; )
                Console.WriteLine(" Hello world");
        }
    }
}
