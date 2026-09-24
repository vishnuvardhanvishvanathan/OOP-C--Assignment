using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrackAcademyApp
{
    internal class Science_Lab : Classroom
    {
        public int Equipment_Count { get; set; }

        public Science_Lab(string Classroom_ID, string Room_Name, int Seating_Capacity, int equipment_Count) : base(Classroom_ID, Room_Name, Seating_Capacity)
        {
            Equipment_Count = equipment_Count;
        }
        public static void AddScienceLab(List<Science_Lab> sciencelabs)
        {
            string classroomId = "CL00" + sciencelabs.Count;

            Console.WriteLine("Science Lab Name: ");
            string classroomName = Console.ReadLine();

            Console.WriteLine("Science Lab Seating Capacity: ");
            int classroomCapacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Science Lab Equipment Count: ");
            int equipmentCount = Convert.ToInt32(Console.ReadLine());

            Science_Lab scienceClassroom = new Science_Lab(classroomId, classroomName, classroomCapacity, equipmentCount);

            sciencelabs.Add(scienceClassroom);
        }
    }
}
