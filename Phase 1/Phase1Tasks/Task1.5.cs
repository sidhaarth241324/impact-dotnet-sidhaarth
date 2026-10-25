using System;
using System.Xml.Linq;

namespace SchoolManagementSystem
{
    class student
    {
        public string name = "Sid";
        public int age = 22;
        public void Details()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}
