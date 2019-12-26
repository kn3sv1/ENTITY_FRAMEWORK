using System;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main2(string[] args)
        {
            using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    Name = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                foreach (var student in context.Students)
                {
                    System.Console.WriteLine(student.Name);
                }
                System.Console.ReadLine();
            }
        }
    }
}
