using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace Inheritance_Assignment
{
    class Delete
    {
        string deleting;
        public Delete()
        {
            Console.WriteLine("Name of the student you want to delete: ");
            deleting = Console.ReadLine();
            string file = "page.txt";
            StreamReader sr = new StreamReader("page.txt");
            StreamWriter sw = new StreamWriter("page.txt", true);
            string students = sr.ReadToEnd();
            string[] studentdata = students.Split(";");
            List<string> studentlist = new List<string>();
            foreach (string student in studentdata)
            {
                studentlist.Add(student);
            }

            foreach (string individual in studentlist.ToList())
            {
                if (individual.Contains(deleting))
                {
                    studentlist.Remove(individual);
                    Console.WriteLine("Student Deleted");
                }
            }
            File.WriteAllText(file, String.Empty);

            //List<string> newstudentlist = studentlist;

            File.WriteAllText(file, string.Join(";", studentlist));
            //put every line into a list. Then the name gets removed in the list. The updated list then puts all the other data back in the text file.
        }
    }
}