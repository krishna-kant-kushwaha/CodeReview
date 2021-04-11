using ReviewCode.CalculateFactorial;
using ReviewCode.CheckAge;
using ReviewCode.EvenOddTest;
using ReviewCode.OOPReview;
using ReviewCode.OOPReview.StudentInfo;
using System;
using System.Collections.Generic;

namespace ReviewCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // //This is for even odd print
            // EvenOdd obj = new EvenOdd();
            // obj.CalculateEvenOdd();
            // //This is for calculate age
            // //CalculateAge age = new CalculateAge();
            // //Console.WriteLine("enter age");
            // //int ages =int.Parse( Console.ReadLine());
            // //var actualagename = age.Calulate(ages);
            // //Console.WriteLine("you are " + actualagename);
            // //Console.ReadLine();
            // //calculate factorial
            // CalculateFacat facObj = new CalculateFacat();
            // Console.WriteLine("enter a number");
            // int FactNum = int.Parse(Console.ReadLine());
            //var results= facObj.FactRecursive(FactNum);
            // Console.WriteLine(results);
            // Console.ReadLine();
            StudentLibraryInfo sliObj = new StudentLibraryInfo();
            Student studentObj = new Student();
            studentObj.FirstName = "Ram";
            studentObj.LastName = "Kumar";
            studentObj.Email = "apk@email.com";
            studentObj.RollNo = 2;
            studentObj.Id = 1;
            studentObj.Address = "KTM";
            // var result = sliObj.SaveStudentInfo(studentObj);

            //Creating list of student
            List<Student> stdListObj = new List<Student>();
            Student studentObj2 = new Student();
            studentObj2.FirstName = "Shyam";
            studentObj2.LastName = "Kumar";
            studentObj2.Email = "apk@email.com";
            studentObj2.RollNo = 1;
            studentObj2.Id = 2;
            studentObj2.Address = "KTM";
            stdListObj.Add(studentObj);
            stdListObj.Add(studentObj2);
            stdListObj.Add(studentObj);
            stdListObj.Add(studentObj2);
            stdListObj.Add(studentObj);
            stdListObj.Add(studentObj2);
            var res = sliObj.SaveBulkStudentInfo(stdListObj);
            Console.ReadLine();
        }
    }
}