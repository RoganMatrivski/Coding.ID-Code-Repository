/*
 * Created by SharpDevelop.
 * User: NAWADATA
 * Date: 26/03/2020
 * Time: 19:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CodingId_Learning
{
    public class Course
    {
        private string name;
        private int sks;
        private int score;

        public Course(string param_name, int param_sks, int param_score)
        {
            name = param_name;
            sks = param_sks;
            score = param_score;
        }

        public int Sks
        {
            get { return sks; }
            set { sks = value; }
        }

        public string getGrade()
        {
            if (this.score < 55) return "D";
            else if (this.score < 70) return "C";
            else if (this.score < 85) return "B";
            else return "A";
        }
    }

    public class University
    {
        private string name;
        private List<Student> list_student;
        private int min_sks;

        public University(string param_name, int param_min_sks)
        {
            name = param_name;
            min_sks = param_min_sks;
            list_student = new List<Student>();
        }

        public List<Student> ListStudent
        {
            get { return list_student; }
            set { list_student = value; }
        }

        public string getStudentStatus(Student param_student)
        {
            if (param_student.countTotalSKS < this.min_sks)
            {
                return string.Format("{0} Credit is not enough to graduate You only have {1}", param_student.Name, param_student.countTotalSKS);
            }

            foreach (var course in param_student.ListCourse)
            {
                if (course.getGrade() == "D")
                {
                    return string.Format("Sorry, {0} Not Pass", param_student.Name);
                }
            }

            return string.Format("Congrats, {0} Pass", param_student.Name);
        }

        public void allStudentStatus()
        {
            Console.WriteLine(name + " Information : ");
            foreach (Student itemStudent in list_student)
            {
                Console.WriteLine(this.getStudentStatus(itemStudent));
            }
        }

    }

    public class Student
    {
        private string name;
        private List<Course> listCourse;

        public Student(string param_name)
        {
            name = param_name;
            listCourse = new List<Course>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Course> ListCourse
        {
            get { return listCourse; }
            set { listCourse = value; }
        }

        public int countTotalSKS
        {
            get
            {
                int totalSKS = 0;
                foreach (var course in listCourse)
                {
                    totalSKS += course.Sks;
                }

                return totalSKS;
            }
        }
    }

    class Program
    {
        //Function or Method to insert Student Data (include List Course) for each Student
        public Student setStudentData(string param_name, int number_course)
        {
            //Create new student
            Student obj_student = new Student(param_name);

            for (int i = 1; i <= number_course; i++)
            {
                Console.Write("Input Course " + i + " Name : ");
                string course_name = Console.ReadLine();

                Console.Write("Input Course " + i + " SKS : ");
                int course_sks = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input Course " + i + " Score : ");
                int course_score = Convert.ToInt32(Console.ReadLine());

                obj_student.ListCourse.Add(new Course(course_name, course_sks, course_score));
            }
            return obj_student;
        }

        public static void Main(string[] args)
        {
        Begin:
            Console.Write("How Many Students? ");
            int number_student = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Min.SKS? ");
            int min_sks = Convert.ToInt32(Console.ReadLine());

            Console.Write("How Many Course? ");
            int number_course = Convert.ToInt32(Console.ReadLine());

            University obj_univ = new University("CodingID Learning Center", min_sks);
            Console.WriteLine();
            //Insert all Student Data
            for (int i = 1; i <= number_student; i++)
            {
                Console.Write("Input Student " + i + " Name : ");
                string student_name = Console.ReadLine();
                Program program = new Program();
                Student obj_student = program.setStudentData(student_name, number_course);
                obj_univ.ListStudent.Add(obj_student);
            }

            obj_univ.allStudentStatus();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            Console.Clear();
            goto Begin;
        }
    }
}
