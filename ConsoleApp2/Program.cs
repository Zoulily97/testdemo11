using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine($"I'm out {i}");
            //    Task task = new Task(
            //        () =>
            //        {
            //            Console.WriteLine($"         I'm in {i}");
            //            Console.WriteLine($"         i'm in task{Task.CurrentId}");
            //            Console.WriteLine("          Thread.CurrentThread-ID" + Thread.CurrentThread.ManagedThreadId);
            //        });
            //        task.Start();
            //}

            //异步
            //Task task = new Task(() => Console.WriteLine("hello world"));




            //Task<int> age = new Task<int>(() => 23);
            //age.Start();
            //Console.WriteLine(age.Result);

            //    string s = null;
            //    int i;
            //    int j;
            //for ( i = 1; i < 7; i++)
            //{ 
            //    for ( j = 1; j < 7-i; j++)
            //    {
            //        s =s+ "";
            //        Console.WriteLine(s);
            //    }
            //    for (j = 1; j <=2*i-1; j++)
            //    {
            //        s+= "*";
            //        Console.WriteLine(s);
            //    }
            //    Console.WriteLine("\n");


            //}
            //   Console.WriteLine(s);

            int n = 7;
            StringBuilder sb = new StringBuilder();
            int i, j ;
            for (i = 1; i <=n; i++)
            {
                for (j = 1; j <= n-i; j++)
                {
                    sb.Append("");
               
                

                }
                  for ( j = 1; j <=2*i-1; j++)
                {
                    sb.Append("*");
                 
                    }

                sb.Append("\n");
                
            }
            
          Console.WriteLine(sb.ToString());
        }
    }
}
