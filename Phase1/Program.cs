using System; //Task 1.5

namespace SchoolManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();  // With using directive:
            student1.Details();

            SchoolManagementSystem.student student2 = new SchoolManagementSystem.student(); // Without using directive:
            student2.Details();

        }
     }

}