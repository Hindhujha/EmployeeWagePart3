using System;
namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {     
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE PROBLEMS");
         
            while (true)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("1.EMPLOYEE IS PRESENT OR NOT");
                Console.WriteLine("2.DAILY EMPLOYEE WAGE");
                Console.WriteLine("3.PART TIME EMPLOYEE & WAGE");
                Console.WriteLine("4.PART TIME EMPLOYEE & WAGE USING SWITCH CASE");
                Console.WriteLine("5.MONTHLY WAGES FOR 20 DAYS");
                Console.WriteLine("6.CALCULATED EMPLOYEE WAGE UNTIL THE MAXIMUM HOURS/DAYS REACHED");
                Console.WriteLine("7.EMPLOYEE WAGE FOR MUTIPLE COMPANIES");
                Console.WriteLine("ENTER YOUR OPTION");

                int select = Convert.ToInt32(Console.ReadLine());
                
                switch (select)
                {
                    case 1:
                       Employee_Attendance check = new Employee_Attendance();
                        check.display(1);
                        check.check(1);
                        break;
                    case 2:
                        Daily_Wage wage = new Daily_Wage();
                        wage.dailywage();
                        wage.emprate();
                        break;
                    case 3:
                        PartTime myObj = new PartTime();
                        myObj.partTime();
                        myObj.wages();
                        break;
                    case 4:
                        Switch call = new Switch();
                        call.partTime();
                        call.switchcase();
                        break;
                    case 5:
                        MonthWage month = new MonthWage();
                        month.month();
                        break;
                    case 6:
                        MaxDays empwage = new MaxDays();
                        empwage.max();
                        break;
                    case 7:
                        Companies multiple=new Companies();
                        multiple.company();
                        break;
                    default:
                        Console.WriteLine("ENTER A CORRECT OPTION");
                        break;

                }
            }
        }
    }
    }

