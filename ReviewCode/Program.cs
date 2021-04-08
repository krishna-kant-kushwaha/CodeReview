using ReviewCode.CalculateFactorial;
using ReviewCode.CheckAge;
using ReviewCode.EvenOddTest;
using System;

namespace ReviewCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //This is for even odd print
            //EvenOdd obj = new EvenOdd();
            //obj.CalculateEvenOdd();
            //This is for calculate age
            //CalculateAge age = new CalculateAge();
            //Console.WriteLine("enter age");
            //int ages =int.Parse( Console.ReadLine());
            //var actualagename = age.Calulate(ages);
            //Console.WriteLine("you are " + actualagename);
            //Console.ReadLine();
            //calculate factorial
            CalculateFacat facObj = new CalculateFacat();
            Console.WriteLine("enter a number");
            int FactNum = int.Parse(Console.ReadLine());
           var results= facObj.FactRecursive(FactNum);
            Console.WriteLine(results);
            Console.ReadLine();




        }
}
}
