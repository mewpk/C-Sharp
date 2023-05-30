using System;

namespace ConsoleApp
{

    class Student
    {
        private static int nextId = 0;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            ID = ++nextId;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public readonly int ID;
    }


}