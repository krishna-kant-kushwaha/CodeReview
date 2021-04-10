using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewCode.CheckAge
{
    public class CalculateAge
    {
        public string Calulate(int age)
        {
            if (age <= 10)
            {
                return "child";
            }
            else if (age > 10 && age <= 20)
            {
                return "Tenage";
            }
            else if (age > 20 && age <= 40)
            {
                return "Adult";
            }
            else if (age >= 40 && age <= 100)
            {
                return "old";
            }
            else
            {
                return "invalid age you entered";
            }
        }
    }
}