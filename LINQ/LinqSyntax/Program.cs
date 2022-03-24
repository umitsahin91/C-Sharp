using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<Student> students = new List<Student>(){
                new Student{
                    ID=1,
                    Name="Ümit",
                    Surname="Şahin"
                    
                },
                new Student{
                    ID=2,
                    Name="Onur",
                    Surname="Coşkun"
                },
                new Student{
                    ID=3,
                    Name="Abdullah Halit",
                    Surname="Korucuoğlu"
                }
            };
          //Query Syntax
          var resultQuery=from s in students
          where s.Name.Contains("u")
          select s.Name;

          foreach (var student in resultQuery)
          {
              Console.WriteLine(student);
          }
          
          //Ekran Çıktısı
          //-------------
          //Onur
          //Abdullah Halit
          

          //Method Syntax
          var resultMethod=students.Where(x=>x.Name.Contains("Ü")).Select(x=>x.Name);
         
          foreach (var student in resultMethod)
          {
              Console.WriteLine(student);
          }
          //Ekran Çıktısı
          //-------------
          //Ümit

        }

        class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            
        }
    }
}