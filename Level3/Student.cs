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

        private string? _Name;
        public string Name
        {
            get
            {
                return _Name!;
            }
            set
            {
                _Name = value;
            }
        }
        /*
        Note that in option 2, we use the null-forgiving operator ! to tell the compiler that we are sure that _Name is not null. This is because we know that if the set accessor is called for Name, then _Name will always be set to a non-null value.
        */
        private int _Age;
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
            }
        }

        public int ID { get; }
    }

}