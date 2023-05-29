

using System;

namespace Level2
{
    struct Student
    {
        public string name;
        public int age;
        public double height;
        public string[] friends;

        public void setName(string nameValue){
            name = nameValue;
        }
    }
    class Program
    {
        // Struct



        static void ptMewpk()
        {
            Console.WriteLine("Hello Mewpk");
        }
        static void Main(string[] args)
        {

            // for each list array
            double[] numbers = { 0.1, 2.32 };

            foreach (double number in numbers)
            {

                Console.WriteLine("Number {0}", number);
            }
            Console.ReadKey();


            // array 2 dimensional
            string[,] person = new string[4, 5] {
            {"John" , "John" , "John" , "John" , "John"},
            {"Bob" , "Bob" , "Bob" , "Bob" , "Bob"},
            {"Sally" , "Sally" , "Sally" , "Sally" , "Sally"},
            {"Robert" , "Robert" , "Robert" , "Robert" , "Robert"}
            };
            // 4 row , 5 column fix

            string[,] teacher = {
                {"John" , "John" , "John" , "John"},{"Bob" , "Bob" , "Bob" , "Bob"}
            };
            // Dynamic array
            Console.WriteLine("Teacher Rows {0}", teacher.GetLength(0));
            Console.WriteLine("Teacher Cols {0}", teacher.GetLength(1));
            Console.WriteLine("Teacher Total Length {0}", teacher.Length);
            Console.ReadKey();

            // foreach

            foreach (string name in person)
            {

                Console.WriteLine("Person Name {0}", name);

            }
            Console.ReadKey();


            // Jagged Array

            int[][] list_number = new int[5][]; // fix rows 

            // Also You can  fix columns

            list_number[0] = new int[5]; // fix row 0 has 5 columns

            // Assign Value

            list_number[1] = new int[] { 10, 20, 30, 40, 50 };

            // or 
            double[][] list_double = new double[3][]
            {
                new double[]{0.4,0.5},
                new double[]{0.4,0.5},
                new double[]{0.4,0.5}
            };

            // or

            string[][] list_str =
            {
                new string[]{"Hello" , "Mewpk"},
                new string[]{"Hello" , "Mewpk"},
                new string[]{"Hello" , "Mewpk"}
            };


            // for loop get data

            for (int row = 0; row < list_str.Length; row++)
            {

                for (int col = 0; col < list_str[row].Length; col++)
                {
                    Console.WriteLine("String array [{0}][{1}] = {2} ", row, col, list_str[row][col]);
                }

            }
            Console.ReadKey();

            // Method 



            ptMewpk();

            Console.ReadKey();




            Student st1 = new Student(); // Initialize the Student struct

            st1.name = "Mewpk";

            Console.WriteLine("Student name: {0}", st1.name);

            Console.ReadKey();

        }
    }
}