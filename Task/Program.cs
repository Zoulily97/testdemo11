using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task() （）中接受一个Action 
            Task task = new Task(
                () =>
                Console.WriteLine("i am in task...")
                );

             task.Start();
            Task<int> age = new Task<int>(
                () =>
                23
                );
            age.Start();
            Console.WriteLine(age.Result);


            Parallel.ForEach(Enumerable.Range(1, 10), x => Console.WriteLine(x));

            Parallel.For(0, 10, x => { Console.WriteLine(x); });
        }
    }
}
