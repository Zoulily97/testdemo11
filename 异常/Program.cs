using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("开始打开");
            //try
            //{
            //    Console.WriteLine("执行");
            //   // Console.WriteLine("错误");
            //    throw new Exception();
            //    Console.WriteLine("执行2");
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    Console.WriteLine("关闭");
            //}




          Grow() ;









        }

        static int Grow()
        {
            try
            {
                Console.WriteLine("执行");
                return 23;
                throw new Exception();
                Console.WriteLine("执行2");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("关闭");
            }
        }
    }
}
