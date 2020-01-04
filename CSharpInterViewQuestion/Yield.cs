using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
   public  class Yield
    {
        static List<int> MyList = new List<int>();
        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);

        }
       
        static void runMethod()
        {
            FillValues();
            foreach(int i in MyList)
            {
                Console.WriteLine(i);
            }
        }

        static IEnumerable<int> Filter()
        {
            List<int> temp = new List<int>();
            foreach(int i in MyList)
            {
                if (i > 3)
                {
                    temp.Add(i);

                }
            }
            return temp;
        }

}
}
