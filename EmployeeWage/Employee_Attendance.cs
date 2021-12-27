using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Employee_Attendance
    {
        
        int IS_FULL_TIME=1;
        public void display(int empcheck)
        {

            Random random = new Random();
            empcheck = random.Next(0, 2);
        }
        public void check(int empcheck)
        {
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
            }
            }
        }
     
    }

   
    

