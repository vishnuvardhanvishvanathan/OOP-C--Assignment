using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrackAcademyApp
{
    internal class Computer_Lab : Classroom
    {
        public int Computer_Count { get; set; }

        public Computer_Lab(string Classroom_ID, string Room_Name, int Seating_Capacity, int computer_Count) : base(Classroom_ID, Room_Name, Seating_Capacity)
        {
            Computer_Count = computer_Count;
        }
        public static void AddComputerLab(List<Computer_Lab> classrooms)
        {
            string classroomId = "CL00" + classrooms.Count;

            Console.WriteLine("Computer Lab Name: ");
            string classroomName = Console.ReadLine();

            Console.WriteLine("Computer Lab Seating Capacity: ");
            int classroomCapacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Computer Lab computer Count: ");
            int computerCount = Convert.ToInt32(Console.ReadLine());

            Computer_Lab computerClassroom = new Computer_Lab(classroomId, classroomName, classroomCapacity, computerCount);

            classrooms.Add(computerClassroom);

        }
    }
}
