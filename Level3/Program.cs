using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create object Class
            Student student1 = new Student("mewpk" , 20);
            Console.WriteLine("Hello Object Class {0}" , student1);
            Console.WriteLine("Name: {0} " , student1.Name);
            Console.WriteLine("Age: {0} " , student1.Age);
            Console.WriteLine("Id: {0} " , student1.ID);
            Console.ReadKey();
            Student student2 = new Student("pk" , 10);
            Console.WriteLine("Hello Object Class {0}" , student2);
            Console.WriteLine("Name: {0} " , student2.Name);
            Console.WriteLine("Age: {0} " , student2.Age);
            Console.WriteLine("Id: {0} " , student2.ID);
            Console.ReadKey();
        }
    }
}
 