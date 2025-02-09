using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Hello " + name); 
        }

        static float Average(int a, int b, int c)
        {
            return (a+b+c) / 3;
        }

        static void Main(string[] args)
        {
            // This is a one line comment
            /* 
            This is a 
            multi-line comment
            */

            //int harry = 34;
            //Console.WriteLine("Hello World!");
            //Console.Write("Suvansh ");
            //Console.WriteLine("Dureja's roll num is: "+harry);


            // Examples of Datatypes
            //int a = 212;
            //float b = 23.23F;
            //double c = 3223.433D;
            //char d = 'r';
            //bool isGreat = true;

            //string inp = Console.ReadLine();

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(inp);

            //char ch = 'a';
            //int x = 136;
            //float f = ch;

            ////char num = (char)x;
            //char num = Convert.ToChar(x);

            //Console.WriteLine(f);
            //Console.WriteLine(num);


            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey "+name);

            //Console.Write("Enter a number: ");
            //string num = Console.ReadLine();
            //Console.WriteLine("Your num + 4 is: " + (Convert.ToInt32(num) + 4));

            //int a = 4;
            //int b = 5;

            //Console.WriteLine("The value of a + b is: " + (a + b));
            //Console.WriteLine("The value of a - b is: " + (a - b));
            //Console.WriteLine("The value of a * b is: " + (a * b));
            //Console.WriteLine("The value of a / b is: " + Convert.ToInt32(b / a));

            //int a = Math.Min(34, 343);
            //int b = Math.Max(34, 343);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //double c = Math.Sqrt(36);
            //Console.WriteLine(c);

            //int d = Math.Abs(-34);
            //Console.WriteLine(d);

            //string hello = "Hello World!";

            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + " Okay");
            //Console.WriteLine(string.Concat(hello, " Okay"));

            //string name = "Suvansh";
            //int age = 19;

            //Console.WriteLine($"My name is {name} and my age is {age}");

            //Console.WriteLine(name[0]);
            //Console.WriteLine(hello.IndexOf("World"));

            //Console.Write("Enter your age: ");
            //string age = Console.ReadLine();
            //int ageNum = Convert.ToInt32(age);

            //if(ageNum<18)
            //{
            //    Console.WriteLine("You are a kid!");    
            //}
            //else if (ageNum >= 18 && ageNum < 60)
            //{
            //    Console.WriteLine("You are an adult!");
            //}
            //else
            //{
            //    Console.WriteLine("You are an old person!");
            //}           

            Greet("Suvansh");
            Greet("Harry");

            Console.WriteLine(Average(2, 13, 4));



            Console.ReadLine();
        }
    }
}
