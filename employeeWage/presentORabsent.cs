using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWage
{
    class presentORabsent
    {
        public void present()
        {

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
        }
    }
}
