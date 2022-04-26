using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWage
{
     class ClassMethod
    {
        public void employeeWage()
        {
            int empwageperhrs = 20;
            int emphrs = 0;
            int workingdays = 0;

            int maxworkinghrs = 100;
            int maxworkingdays = 20;

            int ispresent = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == ispresent)
            {
                Console.WriteLine("employee is present");

            }
            else
            {
                Console.WriteLine("employee is absent");
            }

          //  while ((emphrs < maxworkinghrs) && (workingdays < maxworkingdays))
           // {
                switch (empCheck)
                {
                    case 1:
                        emphrs += 8;
                        break;
                    case 2:
                        emphrs += 4;
                        break;
                    case 0:

                        emphrs = 0;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                workingdays++;

          //  }


            Console.WriteLine("Total Working Hours : " + emphrs);
            Console.WriteLine("Total working Days Per Month : " + workingdays);
            int monthsalary = empwageperhrs * emphrs;
            Console.WriteLine("Total Salary of Employee per Month : " + monthsalary);
        }
    }
}
        
    

