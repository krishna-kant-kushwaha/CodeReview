using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewCode.EvenOddTest
{

   public class EvenOdd
    {
        public void CalculateEvenOdd()
        {
            string even = "";
            string odd = "";
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    if (i == 2)
                        even = even + i;
                    else
                    even = even+"," + i;
                }
                else
                {
                    if (i == 1)
                        odd = odd + i;
                    else
                    odd = odd + "," + i;
                }
            }
            Console.WriteLine("even =" + even);
            Console.WriteLine("odd =" + odd);
            Console.ReadLine();
        }
    }
}
