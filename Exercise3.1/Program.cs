using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Exercise3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\EneidaFiles\\Breakfast.xml";

            string  breakfast;
            Class1 ReadFile = new Class1();
            Console.WriteLine("Activity 1");
            Console.WriteLine("Which breakfast you want to know the price of?");
            breakfast = Console.ReadLine();
            ReadFile.Readfile(filePath, breakfast);
        }
    }
}
