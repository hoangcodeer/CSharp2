using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace slide8
{
    class Program
    {
        /*static void Main()
        {
            Thread t = new Thread(new ThreadStart(MethodA));
            t.Start();
            MethodB();
        }
        static void MethodA()
        {
            for (int i = 0; i < 50; i++)
                Console.Write("0");
        }
        static void MethodB()
        {
            for (int i = 0; i < 50; i++)
                Console.Write("1");
        }*/

        /* public static void CallToChildThread()
         {
             Console.WriteLine("Thread con bat dau!!!");
         }

         static void Main(string[] args)
         {
             Console.WriteLine("Da luong trong C#");
             Console.WriteLine("Vi du minh hoa cach tao Thread");
             Console.WriteLine("----------------------------------");
             ThreadStart childref = new ThreadStart(CallToChildThread);
             Console.WriteLine("Trong Main Thread: tao thread con.");
             Thread childThread = new Thread(childref);
             childThread.Start();
             Console.ReadKey();
         }*/
        /*public static void CallToChildThread()
        {
            Console.WriteLine("Bat dau Thread con!!!");

            // Thread nay dung khoang 5000 milisecond
            int sleepfor = 5000;

            Console.WriteLine("Thread con dung trong khoang {0} giay", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Thread con phuc hoi!!!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Da luong trong C#");
            Console.WriteLine("Vi du minh hoa quan ly Thread");
            Console.WriteLine("---------------------------------");

            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("Trong Main Thread: tao Thread con.");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }*/

        /* public static void CallToChildThread()
         {
             try
             {
                 Console.WriteLine("Bat dau Thread con!!!");

                 // gia su chung ta dem tu 0 toi 10
                 for (int counter = 0; counter <= 10; counter++)
                 {
                     Thread.Sleep(500); //dung trong khoang 5 giay
                     Console.WriteLine(counter);
                 }

                 Console.WriteLine("Thread con hoan thanh.");
             }

             catch (ThreadAbortException e)
             {
                 Console.WriteLine("Thread Abort Exception!!!");
             }
             finally
             {
                 Console.WriteLine("Khong the bat Thread Exception!!!");
             }
         }
         static void Main(string[] args)
         {
             Console.WriteLine("Da luong trong C#");
             Console.WriteLine("Vi du minh hoa huy Thread");
             Console.WriteLine("-------------------------------------");

             ThreadStart childref = new ThreadStart(CallToChildThread);
             Console.WriteLine("Trong Main Thread: tao Thread con.");
             Thread childThread = new Thread(childref);
             childThread.Start();

             //dung Main Thread trong khoang 2 giay
             Thread.Sleep(2000);

             //bay gio huy thread con
             Console.WriteLine("Trong Main Thread: huy Thread con.");

             childThread.Abort();
             Console.ReadKey();
         }*/

        /*class Student
        {
            public string Name { get; set; }
            public DateTime BirthDay { get; set; }
        }
        static void Main()
        {
            Thread t1 = new Thread(Print);
            //chạy thread t1 và truyền tham sô cho phương thức Print
            t1.Start(new Student() { Name = "Fpoly", BirthDay = new DateTime(2010, 07, 01) });
            Console.ReadKey();
        }
        static void Print(object obj)
        {
            Student st = (Student)obj;
            Console.Write("BirthDay's " + st.Name + ":\t" + st.BirthDay.ToShortDateString());
        }*/
        /*class Student
        {
            public string Name { get; set; }
            public DateTime BirthDay { get; set; }
        }
        static void Main()
        {
            Thread t1 = new Thread((obj) =>
            {
                Student st = (Student)obj;
                Console.Write(st.Name + "\t" + st.BirthDay.ToShortDateString());
            });

            t1.Start(new Student() { Name = "Fpoly", BirthDay = new DateTime(2010, 07, 01) });

            Console.ReadKey();
        }*/

        /* static void Main(string[] args)
         {
             Thread t1 = new Thread(() =>
             {
                 Thread.Sleep(1000);
                 Console.WriteLine("Thread t1 started");
             });
             t1.IsBackground = true;
             t1.Start();
             Console.WriteLine("Main thread ending...");
         }*/
        /*  public void one(object o)
          {
              for (int i = 0; i <= 3; i++)
              {
                  Console.WriteLine("One executed");
              }
          }
          public void two(object o)
          {
              for (int i = 0; i <= 3; i++)
              {
                  Console.WriteLine("Two executed");
              }
          }
          public void three(object o)
          {
              for (int i = 0; i <= 3; i++)
              {
                  Console.WriteLine("Three executed");
              }
          }
          static void Main()
          {
              Program d = new Program();

              for (int i = 0; i < 3; i++)
              {
                  ThreadPool.QueueUserWorkItem(new WaitCallback(d.one));
                  ThreadPool.QueueUserWorkItem(new WaitCallback(d.two));
                  ThreadPool.QueueUserWorkItem(new WaitCallback(d.three));
              }

              Console.Read();
          }*/

        public static void Main(string[] args)
        {
            // Sét đặt tên cho thread hiện thời
            // (Đang là thread chính).
            Thread.CurrentThread.Name = "Main";
            Console.WriteLine("Code of " + Thread.CurrentThread.Name);
            Console.WriteLine("Create new thread");
            // Tạo một thread.
            Thread letgoThread = new Thread(LetGo);
            // Đặt tên cho thread này.
            letgoThread.Name = "Let's Go";
            letgoThread.Start();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Code of " + Thread.CurrentThread.Name);
                Thread.Sleep(30);
            }
            Console.Read();
        }
        public static void LetGo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Code of " + Thread.CurrentThread.Name);
                Thread.Sleep(50);
            }
        }
    }
}
