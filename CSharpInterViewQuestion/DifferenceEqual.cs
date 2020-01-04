using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
    public class DifferenceEqual
    {
        public void EqualCompare()
        {
            object o = "This is the test";
            //object o1 = o;

            //Creating new object with same content
            object o1 = new string("This is the test");

            Console.WriteLine(o ==o1);
            Console.WriteLine(o.Equals(o1));
            // Console.WriteLine();

            //But this can be the true. because in string both method only always always compare content comparisions.
            string a = "Dinesh";
            string b = "Dinesh";
            Console.WriteLine(a ==b);
            Console.WriteLine(a.Equals(b));


        }
    }
}
