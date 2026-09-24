using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrackAcademyApp
{
    internal class Student : Person
    {
        private string Student_ID;

        public string _Student_ID 
        {
            get {  return Student_ID; }
        }

        private int Contact_Number {  get; set; }

        public Student(string Student_Id, string Name, int Contact_Number) : base(Name)
        {
            Student_ID = Student_Id;
            this.Contact_Number = Contact_Number;
        }


    }
}
