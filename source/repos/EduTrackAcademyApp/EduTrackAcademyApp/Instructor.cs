using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrackAcademyApp
{
    internal class Instructor : Person
    {
        private string Instructor_ID;

        public string _Instructor_ID { get { return Instructor_ID; } set { Instructor_ID = value; } }

        private string Employee_Number { get; }

        public string Subject_Specialization { get; set; }

        public Instructor(string Instructor_ID,string name,string Employee_Number,string Subject_Specialization) :base(name)
        {
            this.Instructor_ID = Instructor_ID;
            this.Employee_Number = Employee_Number;
            this.Subject_Specialization = Subject_Specialization;
        }

        public static void AddInstructor(List<Instructor> instructors)
        {
            string Inst_Id = "I00" + instructors.Count;
            string Emp_Num = "E00" + instructors.Count;
            Console.WriteLine("Instructor Name: ");
            string Inst_Name = Console.ReadLine();

            Console.WriteLine("Instructor Subject Specialization: ");
            string Inst_Spec = Console.ReadLine();

            Instructor instructor = new Instructor(Inst_Id, Inst_Name, Emp_Num, Inst_Spec);

            instructors.Add(instructor);

        }

    }
}
