using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace CSharpInterViewQuestion
{

    //concerency used for the increase the useablity and Parralelism is  for performance (Thread).
    class ConcurrencyParallelism
    {
        public void Demo()
        {


            //Thread is the other way to execute block of code or process
            //This the way we can create the thread

            Thread thread = new Thread(SomeMethodName);
            thread.Start();

            Console.WriteLine("This line will be run in the different thread.");




            NewMethod();
            NewMethod1();

            //for the creating new way in this way we create new thread. 
           // Task.Factory.StartNew(NewMethod);
         //   Task.Factory.StartNew(NewMethod1);

            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine();

        }

        private void SomeMethodName()
        {
            Task.Delay(50000).Wait();
            Console.WriteLine("This is the someMethod block");
        }

        private static async void NewMethod1()
        {
            // Task.Delay(10000).Wait();
            await Task.Delay(10000);


            Console.WriteLine("Second Action is processing. ");
        }

        private static  async void NewMethod()
        {
            await Task.Delay(10000);
            // Task.Delay(10000).Wait();
            Console.WriteLine("First Action is processing. ");
        }
    }
}
