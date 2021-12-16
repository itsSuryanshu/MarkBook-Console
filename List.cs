using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inheritance_Assignment
{
    class List
    {
        string data;
        public List()
        {
            StreamReader sr = new StreamReader("page.txt");
            data = sr.ReadToEnd();
            string[] studentdata = data.Split(";");
            foreach (var line in studentdata)
            {
                Console.WriteLine(line);
            }

            data = sr.ReadLine();
        }
    }
}