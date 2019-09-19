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
        public void Readfile(string filePath, string menu)
        {
            using (XmlReader reader = XmlReader.Create(@filePath))
                while (reader.Read())
                {
                        if (reader.Name == "name") 
                        {
                            if (reader.ReadString().Equals(menu))
                            {
                                reader.ReadToNextSibling("price");
                                Console.WriteLine("The price of the food is: " + reader.ReadString());
                                Console.ReadLine();
                            }
                        }
                 }
        }
    }
}
