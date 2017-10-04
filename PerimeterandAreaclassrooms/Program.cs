using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterandAreaclassrooms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramExits = true;

            while (ProgramExits == true)

            {
                //prompts user to enter values
                Console.WriteLine("Welcome to Grand Circus");
                Console.WriteLine("Please enter width value.");

                double width, length, Area;


                width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the value for length.");

           
                length = double.Parse(Console.ReadLine());
                Area = length * width;

                Console.WriteLine("The area of this room is {0}", Area);

                double Perimeter;
                Perimeter = length * 2 + width * 2;

                Console.WriteLine("The  perimeter of this room is {0}", Perimeter);



                // user 
                bool lastdecision = true;
                while (lastdecision == true)
                {
                    string userChoice;
                    Console.WriteLine("Do you want to run this again? yes or no");

                    userChoice = Console.ReadLine();

                    if (userChoice == "no" || userChoice == "No")
                    {
                        ProgramExits = false;
                        Console.WriteLine("Bye bye");
                        break;
                    }
                    else if (userChoice == "yes" || userChoice == "Yes" || userChoice == " ")
                    {
                        lastdecision = false;
                    }
                    else
                    {
                        lastdecision = true;
                    }
                }


            }

        }
    }
}
