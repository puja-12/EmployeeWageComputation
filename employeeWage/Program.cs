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
                Console.WriteLine("select number\n1)check present or absent\n2)wage computation\n3) " +
                    "part time wage compuatation\n4) using switch case\n5) Monthlywage\n6)" +
                    " maxhrANDdays\n7) employee Wage using class method and variable\n" +
                    "8)wage for multiple companies\n9)total wage for each company\n10)different Empwages for different companies");

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
                    //using switch case
                    case 4:
                        Usingswitchcase usingswitch = new Usingswitchcase();
                        usingswitch.switchCase();
                        break;
                    case 5:
                        monthlyWage monthly = new monthlyWage();
                        monthly.monthly();
                        break;
                    case 6:
                        maxhrANDdays Wage = new maxhrANDdays();
                        Wage.totalWage();
                        break;
                    case 7:

                        ClassMethod method = new ClassMethod();
                        method.employeeWage();
                        break;
                    case 8:

                        WageforComp total = new();
                        total.salary("abc", 20, 20, 100);
                        total.salary("xyz", 18, 21, 80);
                        total.salary("pqr", 19, 24, 90);
                        break;
                    case 9:
                        totalWageForEachCompany total1 = new totalWageForEachCompany("abc", 20, 2, 10);
                        totalWageForEachCompany total2 = new totalWageForEachCompany("xyz", 10, 4, 20);
                        total1.salary();
                        Console.WriteLine(total1.ToString());
                        total2.salary();
                        Console.WriteLine(total2.ToString());
                        break;
                    case 10:
                        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                        empWageBuilder.addCompanyEmpWage("Wipro", 20, 2, 10);
                        empWageBuilder.addCompanyEmpWage("TCS", 10, 4, 20);
                        empWageBuilder.computeEmpWage();
                        break;

                       

                }
            }
        }
    }
}
    

    

