using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using static CSharpInterViewQuestion.Anonymous;

namespace CSharpInterViewQuestion
{
    class Program
    {

        #region StringReversed
        public static void Example1(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i  <  j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string result = new string(charArray);
            Console.WriteLine(result);
        }
        #endregion


        #region PalindromCheck
        public static void CheckPalindrom(string str)
        {
           
            for (int i = 0, j = str.Length - 1; i <  str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                  
                    Console.WriteLine("Not Pallindrom");

                }
                else
                {
                   
                    Console.WriteLine("Palindrom");
                }
             
            }

        }

        #endregion

        #region SenteceWordReverse
        public static void ReverseWordSentece(string str)
        {
            int i;
       

            int End = str.Length - 1;
            int Start = str.Length - 1;
            StringBuilder stringBuilder = new StringBuilder();

            while (Start > 0)
            {
                if(str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        stringBuilder.Append(str[i]);
                        i++;
                    }
                    stringBuilder.Append(' ');
                    i++;
                }
                Start--;
            }
            for (i=0; i<=End; i++)
            {
                stringBuilder.Append(str[i]);
            }
            Console.WriteLine(stringBuilder.ToString());

        }

        #endregion

       public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            StringReverse srRev = new StringReverse();
            StringReverse.Reverse("Dinesh");
            Example1("Diya120");
            Palindrome pm = new Palindrome();
                pm.CheckPalindrom("Checkme");
            //Palindrome.CheckPalindrom("Ckeckme");
            //Palindrome.CheckPalindrom("BoB");
            CheckPalindrom("Dinesh");
            CheckPalindrom("BoB");
            ReverseWordOrder.ReverseWordOrd("This is the Example of the question?");

            ReverseWordSentece("This is the Exampel");

            CountingOccurrence.Countcharacter("Dinesh Ghimire");

            FieldAndProperties np = new FieldAndProperties(250);
            Console.WriteLine(np.Age);
            //  FieldAndProperties np2 = new FieldAndProperties();
            //  np2.Age = 35;
            //  np2.Age = 135;
            ////  np2.Age = 235;

            //  Console.WriteLine(np2.Age);

            Loops lp = new Loops();
            lp.forLoop();
           lp.While();
          //  lp.infiniteLoop();

            #region AutoMapper

            AutoMapper amp = new AutoMapper();
            amp.FirstName = "Dinesh";
            amp.LastName = "Ghimire";
            amp.Salary = 5000;
            Console.WriteLine(amp.FirstName  + amp.LastName + amp.Salary);
            Automapper2 amp2 = new Automapper2();
            amp2.FirstName = amp.FirstName;
            amp2.LastName = amp.LastName;

            //create Map
            //Mapper.CreateMap<AutoMapper, Automapper2>();

            //Use Create Map
            //Automapper2 amp2 = Mapper.Map<amp>(amp);

            #endregion

            VarVsDynamic vc = new VarVsDynamic();
            vc.varExample();

            DifferenceEqual dequal = new DifferenceEqual();
            dequal.EqualCompare();

            ConcurrencyParallelism cp = new ConcurrencyParallelism();
            cp.Demo();

            //Anony

            Anonymous an = new Anonymous();
            myDelegate2 newDeligate = new myDelegate2(Graeting);
            Console.WriteLine("Anonymouse printing");
            Console.WriteLine(newDeligate.Invoke("Dinesh"));


            myDelegate2 AnonyDelegate = delegate (string name)
            {
                //This is the method body
                return "Anonumouse method" + name;
            };

            Console.WriteLine(AnonyDelegate.Invoke("ANONYMOUSMETHOD"));

            //this is the way we assigned the data types in the run times .

            //Console.WriteLine(Generic<int>.CompareFunction(2, 3));
            //Console.WriteLine(Generic<string>.CompareFunction("Dinesh", "dinesh"));

            Console.WriteLine(Generic.CompareFunction<int>(2, 3));


            //Array and List
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Dinesh",
                Salary = 15000
            };

            Employee employee1 = new Employee()
            {
                Id = 1,
                Name = "Ramesh",
                Salary = 10000
            };

            Employee employee2 = new Employee() {
                Id = 1,
                Name = "Shanker",
                Salary = 15000
            };

            Employee[] employees = new Employee[2];
            employees[0] = employee;
            employees[1] = employee1;
            //This will be ok at compile time but when you run this will throw the index out of bound exceptions.
            // employees[2] = employee2;

            Console.WriteLine(employees[1].Name);
            Console.WriteLine(employee1.Salary);



            //So if i have a list then that not a problem

            List<Employee> empl = new List<Employee>(2);
            empl.Add(employee);
            empl.Add(employee1);
            empl.Add(employee2);

            //If you want to retrive the info it is indexed based
            Console.WriteLine(empl[0].Name);

            Employee emp = empl[0];
            Console.WriteLine(emp.Id + emp.Name + emp.Salary);

            foreach(Employee in emp)
            {

            }


        }
    }
}
