using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrackAcademyApp
{
    internal abstract class Classroom
    {
        private string Classroom_ID;
        public string _Classroom_ID
        {
            get { return this.Classroom_ID; }
        }
        public string Room_Name { get; }
        public int Seating_Capacity { get; set; }

        public Classroom(string Classroom_ID, string Room_Name, int Seating_Capacity)
        {
            this.Classroom_ID = Classroom_ID;
            this.Room_Name = Room_Name;
            this.Seating_Capacity = Seating_Capacity;
            

        }
       
    }
}
