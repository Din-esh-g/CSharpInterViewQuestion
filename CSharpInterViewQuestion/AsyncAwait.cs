using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpInterViewQuestion
{
  public  class AsyncAwait
    {

        public void Demo(){
            Method();
            Console.WriteLine("This the origin method which calling other method.");

        }

        public  async void Method()
        {
           await Task.Run(new Action(OtherHeavyTask));
            Console.WriteLine("Waiting for Other heavy task. ");
        }

        public void OtherHeavyTask()
        {
            Thread.Sleep(20000);
        }
    }
}
