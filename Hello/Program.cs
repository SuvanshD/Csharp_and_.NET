using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
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


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hey "+name);

            Console.Write("Enter a number: ");
            string num = Console.ReadLine();
            Console.WriteLine("Your num + 4 is: " + (Convert.ToInt32(num) + 4));



            Console.ReadLine();
        }
    }
}
