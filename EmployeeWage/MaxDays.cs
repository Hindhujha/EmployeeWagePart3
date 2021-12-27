using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    
    public class MaxDays:MonthWage
    {
        public const int MAX_HRS_IN_MONTH = 100;

        public void max()
        {
            int totalworkingdays = 0, totalEmpHrs = 0; ;

            while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalworkingdays < NO_OF_WORKING_DAYS)
            {
                totalworkingdays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("DAY: " + totalworkingdays + " Employee working Hrs : " + empHrs);
            }

            int totalEmpWage = totalEmpHrs * EMP_RATE_HR;
            Console.WriteLine("TOTAL EMPLOYEE WAGE :" + totalEmpWage);
        }
    }
}
