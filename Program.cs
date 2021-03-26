using System;
/**
Name: Connor Hall
Date of completion: 3/26/2021
Please be sure to comment your code - provide a comment for each structure use in 
program.
 */

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Date
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            //Define Variables
            string ename = "";
            int depNum = 0;
            int hSalary = 0;
            int hoursWorked = 0;
            int report = 1;

            //Global
            string [] departments = new string[] {"Personnel", "Marketing", "Care and Support", "Information Technology", "Sales", "Legal", "Accounting"};
            int[] gSalary = new int[] {0, 0, 0, 0, 0, 0, 0};

            //Program Start
            Console.WriteLine("Welcome to the MLPS Dog Boarding Payroll Reporter.");
            while (true) {
                Console.WriteLine("Please enter the Employees Name or write \"Done\" when you have finished to generate a gross payroll for every department");
                ename = Console.ReadLine();
                if(ename.ToLower() == "done"){
                    //We are done here go to report
                    break;
                }
                Console.WriteLine($"Please enter {ename}\'s department number.  For a list of all deparments please refer to Departments.md");
                depNum = Convert.ToInt32(Console.ReadLine());
                if(depNum >= 1 && depNum <= 7) {
                    depNum--;
                    Console.WriteLine(depNum);
                    //Hourly Salery
                    Console.WriteLine($"What is {ename}\'n hourly salary");
                    hSalary = Convert.ToInt32(Console.ReadLine());
                    //Hours Worked
                    Console.WriteLine($"How many Hours did {ename} work?");
                    hoursWorked = Convert.ToInt32(Console.ReadLine());
                    //Employees Report
                    Console.WriteLine($"\nReport #{report}");
                    Console.WriteLine($"Name: {ename}");
                    Console.WriteLine("Gross Salary: " + hSalary*hoursWorked);
                    Console.WriteLine($"Department Name: {departments[depNum]}\n");
                    //Adding their salary to the total for the department
                    gSalary[depNum] = gSalary[depNum] + hSalary*hoursWorked;
                
                } else {
                    Console.WriteLine("Invalid Responce");
                }
                
            }
            //Print report with time
            Console.WriteLine($"Deparment Gross Salary Report as of {date}");
            for(int i = 0; i <= departments.Length-1; i++) {
                Console.WriteLine($"{departments[i]} Total: {gSalary[i]}");
            }
        }
    }
}
