// See https://aka.ms/new-console-template for more information
using System;
namespace employeeWage
{
    public class Employee
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to employee wage program!");
            while (true)
            {
                Console.WriteLine("select number\n1)check present or bsent\n2)wage computation\n3) part time wage compuatation\n ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        presentORabsent p1 = new presentORabsent();
                        p1.present();
                        break;

                    //Wagecalculation
                    case 2:

                        Wagecalculation w1 = new Wagecalculation();
                        w1.calculation();
                        break;
                    //ParttimeEmployee
                    case 3:
                        Parttimeemployee part = new Parttimeemployee();
                        part.partTime();
                        break;
                }
            }
        }
    }
}
