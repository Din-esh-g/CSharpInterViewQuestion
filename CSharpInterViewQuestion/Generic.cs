using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
    //Change the class to generic
    public class Generic
    {
        public static bool  CompareFunction <T>(T a, T b)
        {
            //Change the == to equal to
            if (a.Equals(b))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        }
}
