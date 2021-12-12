using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inheritance_Assignment
{
    class Student
    {
        public string name;
        public int age;
        public int grade;
        public int courses;
        public string course1;
        public string mark1;
        public double mark1int;
        public string course2;
        public string mark2;
        public double mark2int;
        public string course3;
        public string mark3;
        public double mark3int;
        public string course4;
        public string mark4;
        public double mark4int;
        public int totalMark;
        public double obtainedMarks;
        public double percentage;

        //Constructor
        //string name, int age, int courses, string course1, string course2, string course3, string course4, double mark1, double mark2, double mark3, double mark4
        public Student()
        {
            Console.WriteLine("Student's name: ");
            name = Console.ReadLine();
            Console.WriteLine("{0}'s age: ", name);
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}'s grade: ", name);
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 12)
            {

                Console.WriteLine("How many courses does {0} have?: ", name);
                courses = Convert.ToInt32(Console.ReadLine());
                totalMark = 100 * courses;
                List<string> coursestw = new List<string>();
                List<string> gradestw = new List<string>();

                for (int x = 0; x < courses; x++)
                {
                    Console.WriteLine("Course {0}: ", x + 1);
                    coursestw.Add(Console.ReadLine());
                    Console.WriteLine("Grade in Course {0}: ", x + 1);
                    gradestw.Add(Console.ReadLine());
                }
                for (int y = courses; y < 4; y++)
                {
                    coursestw.Add("0");
                    gradestw.Add("0");
                }

                course1 = coursestw[0];
                mark1 = gradestw[0];
                mark1int = Convert.ToInt32(mark1);

                course2 = coursestw[1];
                mark2 = gradestw[1];
                mark2int = Convert.ToInt32(mark2);

                course3 = coursestw[2];
                mark3 = gradestw[2];
                mark3int = Convert.ToInt32(mark3);

                course4 = coursestw[3];
                mark4 = gradestw[3];
                mark4int = Convert.ToInt32(mark4);
            }
            else
            {
                courses = 4;
                Console.WriteLine("{0}'s 1st course: ", name);
                course1 = Console.ReadLine();
                Console.WriteLine("{0}'s mark in {1}?: ", name, course1);
                mark1 = Console.ReadLine();
                mark1int = Convert.ToInt32(mark1);
                Console.WriteLine("{0}'s 2nd course: ", name);
                course2 = Console.ReadLine();
                Console.WriteLine("{0}'s mark in {1}?: ", name, course2);
                mark2 = Console.ReadLine();
                mark2int = Convert.ToInt32(mark2);
                Console.WriteLine("{0}'s 3rd course: ", name);
                course3 = Console.ReadLine();
                Console.WriteLine("{0}'s mark in {1}?: ", name, course3);
                mark3 = Console.ReadLine();
                mark3int = Convert.ToInt32(mark3);
                Console.WriteLine("{0}'s 4th course: ", name);
                course4 = Console.ReadLine();
                Console.WriteLine("{0}'s mark in {1}?: ", name, course4);
                mark4 = Console.ReadLine();
                mark4int = Convert.ToInt32(mark4);
                totalMark = 400;

            }
            StreamWriter sw = new StreamWriter("page.txt", true);
            sw.WriteLine("Name: {0}, Age: {1}, Grade: {2}, Courses: {3}, Course 1: {4}, Mark: {5}, Course 2: {6}, Mark: {7}, Course 3: {8}, Mark: {9}, Course 4: {10}, Mark: {11}", name, age, grade, courses, course1, mark1, course2, mark2, course3, mark3, course4, mark4);
            sw.Close();
        }

        public void CalculateTotalMark()
        {
            obtainedMarks = mark1int + mark2int + mark3int + mark4int;
        }

        public void CalculateMarkPercentage()
        {
            percentage = (double)obtainedMarks / totalMark * 100;
        }

        public double Percentage()
        {
            string.Format("{0:0.00}", percentage);
            Console.WriteLine("{0} of {1} years of age has a {2}% average", name, age, string.Format("{0:0.00}", percentage));
            return 0;
        }

    }
}