using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewCode.CalculateFactorial
{
  public class CalculateFacat
    {
        public int Fac(int a)
        {
            int result = 1;
            for(int i = 1; i <=a; i++)
            {
                result = result * i; 
            }
            return result;
        }
        public int FactRecursive(int a)
        {
            if (a == 1)
                return 1;
            else
                return a * FactRecursive(a - 1);

            

        }
        
    }
}
