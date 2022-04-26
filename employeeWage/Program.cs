// See https://aka.ms/new-console-template for more information
using System;
namespace employeeWage
{
    public class Employee
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to employee wage program!");
            presentORabsent p1 = new presentORabsent();
            p1.present();
        }
    }
}
