using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Switch:PartTime
    {

        public void switchcase()
        {
           

            switch (empcheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
                 
            }
            empWage = empHrs * EMP_RATE_HR;
            Console.WriteLine("EMPLOYEE WAGE IS:  " + empWage);
          
        }
    }
}
