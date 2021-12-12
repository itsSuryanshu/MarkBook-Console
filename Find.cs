using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inheritance_Assignment
{
    class Find
    {
        string found;
        string name;
        public Find()
        {
            Console.WriteLine("Enter the name of the student you are looking for: ");
            name = Console.ReadLine();
            try
            {
                StreamReader sr = new StreamReader("page.txt");
                found = sr.ReadLine();
                while (found != null)
                {
                    if (found.Contains(name))
                    {
                        string newfound = Convert.ToString(found);
                        string[] splitfound = newfound.Split(',');
                        foreach (var infofound in splitfound)
                        {
                            Console.WriteLine($"{infofound}");
                        }
                    }
                    found = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {
                Console.WriteLine("ERROR!!");
            }


        }
    }
}