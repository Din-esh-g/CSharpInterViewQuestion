
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterViewQuestion
{
    public abstract class Customer
    {
public  Customer()
        {
            this._id = Guid.NewGuid();
        }

        private Guid _id;

        public Guid ID
        {
            get
            {
                return this._id;
            }
           
        }

        public String ToString()
        {
            return "this is test";
        }




    }
}
