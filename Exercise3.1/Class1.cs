using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Exercise3._1
{
    class Class1
    {
        public void Readfile(string filePath, string food)
        {
            bool foundItem = false;
            using (XmlReader reader = XmlReader.Create(@filePath))
                while (reader.Read() && !foundItem)
                {
                        if (reader.Name == "name") 
                        {
                            if (reader.ReadString().Equals(food))
                            {
                                foundItem = true;
                                reader.ReadToNextSibling("price");
                                Console.WriteLine("The price is: " + reader.ReadString());
                                reader.ReadToNextSibling("description");
                                Console.WriteLine(reader.ReadString());
                                reader.ReadToNextSibling("calories");
                                Console.WriteLine("This food contains the following calories: " + reader.ReadString());
                            }
                        }
                 }
            if (!foundItem)
                Console.WriteLine("We couldn't find item: " + food);
        }
    }
}
