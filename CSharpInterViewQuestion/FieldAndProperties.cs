using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
    public class FieldAndProperties
    {
        int age = 100;
        public FieldAndProperties(int age)
        {
            this.age = age;
        }

        public FieldAndProperties()
        {

        }

        ~FieldAndProperties()
        {
            age = 0;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if( value>0 && value < 150)
                {
                    age = value;
                }

                else
                {
                    throw new ArgumentException($"Provided value is not accepatable. {value} ");
                   // Console.WriteLine("Value must be in between 0 and 150");
                }
            }

        }
       
    }
}
