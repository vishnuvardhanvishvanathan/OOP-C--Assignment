using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrackAcademyApp
{
    internal class Course_Enrollment
    {
        private string Enrollment_ID;
        public string _Enrollment_ID { get {  return Enrollment_ID; } }
        public DateTime Enrollment_Date { get; set; }
        public Student student { get; }
        public Classroom @class { get;}
        public Instructor instructor { get; set; }


    }
}
