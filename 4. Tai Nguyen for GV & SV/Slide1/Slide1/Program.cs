using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide1
{
    /* class Student
     {
         //non-statcic data members  
         public string StudentName;
         public string Course;
         public void SetStudentDetails(string StuName, string Cou)
         {
             StudentName = StuName;
             Course = Cou;
         }
         public void DisplayStudentDetails()
         {
             Console.WriteLine(StudentName + " - " + Course);
         }

         //static data members  
         public static string CollegeName = "FPT PolyTechnic";
         public static string CollegeAddress = "391A Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Hồ Chí Minh";

         //static methods  
         public static void DisplayCollegeDetails()
         {
             Console.WriteLine(CollegeName);
             Console.WriteLine(CollegeAddress);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             //access static members  
             Student.DisplayCollegeDetails();

             //acess non-static members  
             Console.WriteLine();
             Student s1 = new Student();
             Student s2 = new Student();
             s1.SetStudentDetails("Thepv", "Phd");
             s2.SetStudentDetails("Nghiemn", "MBA");
             s1.DisplayStudentDetails();
             s2.DisplayStudentDetails();
             Console.Read();
         }
     }*/
    class Program
    {
        /*static void Main(string[] args)
        {
            clsCalculation objCal = new clsCalculation();
            objCal.Multiplication(5, 6);
            objCal.Division(5, 6);
            objCal.Addition(5, 6);
            objCal.Substraction(5, 6);
        }*/
        static void Main(string[] args)
        {
            int times = 10000000;
            for (int listSize = 1; listSize < 10; listSize++){
                List<string> list = new List<string>();
                HashSet<string> hashset = new HashSet<string>();
                for (int i = 0; i < listSize; i++)
                {
                    list.Add("string" + i.ToString());
                    hashset.Add("string" + i.ToString());
                }
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for (int i = 0; i < times; i++){
                    list.Remove("string0");
                    list.Add("string0");
                }
                timer.Stop();
                Console.WriteLine(listSize.ToString() + " item LIST strs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                timer = new Stopwatch();
                timer.Start();
                for (int i = 0; i < times; i++){
                    hashset.Remove("string0");
                    hashset.Add("string0");
                }
                timer.Stop();
                Console.WriteLine(listSize.ToString() + " item HASHSET strs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                Console.WriteLine();
            }
            for (int listSize = 1; listSize < 10; listSize += 3){
                List<object> list = new List<object>();
                HashSet<object> hashset = new HashSet<object>();
                for (int i = 0; i < listSize; i++)
                {
                    list.Add(new object());
                    hashset.Add(new object());
                }
                object objToAddRem = list[0];
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for (int i = 0; i < times; i++)
                {
                    list.Remove(objToAddRem);
                    list.Add(objToAddRem);
                }
                timer.Stop();
                Console.WriteLine(listSize.ToString() + " item LIST objs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                timer = new Stopwatch();
                timer.Start();
                for (int i = 0; i < times; i++){
                    hashset.Remove(objToAddRem);
                    hashset.Add(objToAddRem);
                }
                timer.Stop();
                Console.WriteLine(listSize.ToString() + " item HASHSET objs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
