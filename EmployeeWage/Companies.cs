using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Companies:PartTime
    {
        public void company()
        { 
            Console.WriteLine("MULTIPLE COMPANIES ARE: ");
            Console.WriteLine("1.DMART  2.RELIANCE 3.AIRTEL 4.IDEA");
            Console.WriteLine("SELECT HOW MANY COMPANIES TO CALCULATE EMPLOYEE WAGE");
            int select = Convert.ToInt16(Console.ReadLine());
           for(int i=1;i<=select;i++)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("TOTAL EMPLOYEE WAGE FOR COMPANY :" + i);
               
                if(select==1)
                {
                    EMP_RATE_HR = 20;
                   
                }
                else if(select==2)
                {
                    EMP_RATE_HR = 40;
                   
                }
                else if(select==3)
                {
                    EMP_RATE_HR = 60;
                    
                }
                else
                {
                    EMP_RATE_HR = 80;
                    
                }

                MaxDays empwage = new MaxDays();
                empwage.max();
            }
            

        }
      
    }
}
