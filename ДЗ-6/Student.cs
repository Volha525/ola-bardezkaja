using System;

namespace StudentsCoffee
    {
    internal class Student
    {
        public string Name;

        public void DoHomework()
        {
            Console.WriteLine($"{Name} did homework");
            
        }

        public void GetCoffee()
        {
            Console.WriteLine($"{Name} got coffee");
        }
    }
}