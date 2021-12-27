using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    
    public class MonthWage:PartTime
    {
        public int NO_OF_WORKING_DAYS = 20;
      
        public void month()
        {
            int totalEmpWage=0;

            for(int day=0; day<NO_OF_WORKING_DAYS ;day++)
            {
                Random random = new Random();
                empcheck = random.Next(0, 3);

                if (empcheck == IS_FULL_TIME)
                {
                    empHrs = 8;
                }
                else if (empcheck == IS_PART_TIME)
                {
                    empHrs = 4;
                }
                else
                {
                    empHrs = 0;
                }
                empWage = empHrs * EMP_RATE_HR;

                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("EMPLOYEE WAGE IS:  " + empWage);

               
            }
            Console.WriteLine("TOTAL EMPLOYEE WAGE: " + totalEmpWage);
        }
    }
}
