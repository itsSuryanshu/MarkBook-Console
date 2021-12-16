using System;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main()
        {
            bool running = true;
            string func;
            do
            {
                Console.WriteLine("Do you want to Add{press a}, Student List{press l}, Find{press f}, Delete{press d}, or Quit{press q}:");
                func = Console.ReadLine();

                if (func == "a")
                {
                    Student student = new Student();
                    student.CalculateTotalMark();
                    student.CalculateMarkPercentage();
                    student.Percentage();

                }

                if (func == "l")
                {
                    List list = new List();
                }

                if (func == "f")
                {
                    Find find = new Find();
                }

                if (func == "d")
                {
                    Delete delete = new Delete();
                }

                if (func == "q")
                {
                    running = false;
                }
            } while (running == true);





        }

    }
}