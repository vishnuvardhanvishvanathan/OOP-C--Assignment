using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTrackAcademyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Intialising Instructor table
            List<Instructor> instructors = new List<Instructor>();

            //Intialising Classroom Labs table
            List<Science_Lab> scienceLabs = new List<Science_Lab>();
            List<Computer_Lab> computerLabs = new List<Computer_Lab>();

            Menu.DisplayMenu();

            Console.WriteLine("What is your option?");
            int option = Convert.ToInt32(Console.ReadLine());

            while (option!=9)
            {   
                if (option == 1)//Registering Instructor
                {
                    Instructor.AddInstructor(instructors);
                }

                if (option == 2)//Adding a Classroom
                {
                    Console.WriteLine("Do you want to add a Computer Lab or Science Lab ?");
                    string choice = Console.ReadLine();
                    if (choice == "Computer Lab")
                    {
                        Computer_Lab.AddComputerLab(computerLabs);
                    }
                    else
                    {
                        Science_Lab.AddScienceLab(scienceLabs);
                    }
                    

                }

                Console.WriteLine("What is your option?");
                option = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
