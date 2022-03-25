using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWhere
{
     class Course
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public int Rank { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>()
             {
               new Course{
                    ID=1,
                    Subject="LINQ Tutorials",
                    Rank=5
                },
                new Course{
                    ID=2,
                    Subject=".NET Threading Tutorials",
                    Rank=4
                },
                new Course{
                    ID=3,
                    Subject="Learn WPF",
                    Rank=3
                }

            };
            //Query Syntax
            var resultQuery = from course in courses
                              where course.Rank > 3
                              select course;

            foreach (var course in resultQuery)
            {
                Console.WriteLine(course.Subject);
            }
            //Ekran Çıktısı
            //--------------
            //LINQ Tutorials
            //.NET Threading Tutorials

            //Method Syntax
            var resultMethod = courses.Where(x => x.Rank > 3);
            foreach (var course in resultMethod)
            {
                Console.WriteLine(course.Subject);
            }
            //Ekran Çıktısı
            //--------------
            //LINQ Tutorials
            //.NET Threading Tutorials

            //------------------------------------------------------------------//

            //MULTİPLE CONDİTİONS

            //Query Sytax
            var resultMultipleQuery = from course in courses
                                      where course.Rank > 3 && course.Subject.Contains("Threading")
                                      select course;
            foreach (var course in resultMultipleQuery)
            {
                Console.WriteLine(course.Subject);
            }
            //Ekran Çıktısı
            //-------------
            //.NET Threading Tutorials

            //Method Syntax

            var resultMultipleMethod=courses.Where(x=>x.Rank>3&&x.Subject.Contains("Threading"));
             foreach (var course in resultMultipleMethod)
            {
                Console.WriteLine(course.Subject);
            }
            //Ekran Çıktısı
            //-------------
            //.NET Threading Tutorials



        }


    }
   
}
