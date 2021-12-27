using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{

    public class PartTime
    {
        public int empcheck;
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public int EMP_RATE_HR = 20;
        public int empHrs = 0;
        public int empWage = 0;
       
        public void partTime()
        {
            Random random =new Random();
            empcheck=random.Next(0,3);
         
        }

        public void wages()
        {
          
            if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if(empcheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_HR;
            
            Console.WriteLine("EMPLOYEE WAGE IS:  " + empWage);
            
        }
    }
  


}
