using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOfType
{
    abstract class Course
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public int Rank { get; set; }
    }

    class FreeCourse : Course
    {

    }
    class PaidCourse : Course
    {
        public decimal Fees { get; set; }
    }

    class LinqOfType
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>()
            {
                new FreeCourse
                {
                    ID=1,
                    Subject="LINQ Tutorials",
                    Rank=5
                },
                new FreeCourse
                {
                    ID=2,
                    Subject=".NET Threading Tutorials",
                    Rank=4
                },
                new PaidCourse
                {
                    ID=3,
                    Subject="Learn WPF",
                    Rank=3
                },
                new PaidCourse
                {
                    ID=4,
                    Subject="Datagrid Tutorials",
                    Rank=3
                }
            };


            //QUERY SYNTAX

            var paidCoursesQuery = from course in courses.OfType<PaidCourse>()
                                   select course;

            foreach (var course in paidCoursesQuery)
            {
                Console.WriteLine(course.Subject);
            }
            //Ekran Çıktısı
            //-------------
            //Learn WPF
            //Datagrid Tutorials


            var freeCoursesQuery = from course in courses.OfType<FreeCourse>()
                                   select course;

            foreach (var course in freeCoursesQuery)
            {
                Console.WriteLine(course.Subject);
            }
            //Ekran Çıktısı
            //-------------
            //LINQ Tutorial
            //.NET Threading Tutorial


            //METHOD SYNTAX

            var paidCoursesMethod = courses.OfType<PaidCourse>();
            foreach (var course in paidCoursesMethod)
            {
                Console.WriteLine(course.Subject);
            }
            //Ekran Çıktısı
            //-------------
            //Learn WPF
            //Datagrid Tutorials



            var freeCoursesMethod = courses.OfType<FreeCourse>();
            foreach (var course in freeCoursesMethod)
            {
                Console.WriteLine(course.Subject);
            }
            //Ekran Çıktısı
            //-------------
            //LINQ Tutorial
            //.NET Threading Tutorial

        }
    }
}
