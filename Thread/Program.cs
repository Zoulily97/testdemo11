using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {


           
            string directory = @"C:\Users\zouzou\Pictures\Screenshots";//文件夹
            string filename = @"lo7";//文件名

            string path = Path.Combine(directory, "f5");//组合成一个路径

            //  Directory.CreateDirectory(path);//创建文件夹

            //File.Create(Path.Combine(path, filename));//文件创建

            string fullFileName = Path.Combine(path, filename);//组合成一个路径

            File.WriteAllText(fullFileName,"12344565");//文件写入内容

            //     Directory.Delete("fg");

            //Extension：文件扩展名相关
            Console.WriteLine("Path.HasExtension(subPath):" + Path.HasExtension(path));//扩展名  没有 false          
            Console.WriteLine("Path.GetExtension(subPath):" + Path.GetExtension(path));//得到扩展名
            Console.WriteLine("Path.GetFileNameWithoutExtension(subPath):" + Path.GetFileNameWithoutExtension(path));
            // Console.WriteLine("Path.ChangeExtension(subPath, \"fei\"):" + Path.ChangeExtension(path, "fei"));//改扩展名

            //Directory：文件夹相关，如：GetDirectoryName
            Console.WriteLine(Directory.GetCurrentDirectory());//活得应用程序当前目录
//-------------
            string filename2 = @"aaa.txt";//文件名

            string path2 = Path.Combine(directory, "zouli");//组合成一个路径

          //  Directory.CreateDirectory(path2);//创建文件夹
          //  File.Create(Path.Combine(path2, filename2));//文件创建
            string fullFileName2 = Path.Combine(path2, filename2);//组合成一个文件路径

            //  File.WriteAllText(fullFileName2, "12345678");//文件写入内容


            //FileStream stream = File.Create(fullFileName2);//获得stream对象

            //stream.Write(
            //    new byte[4] { 33, 34, 35, 36 }, //要写入的字节
            //    0,
            //    4  /*缓冲的大小*/);
            //stream.Flush();

            //FileStream stream = null;
            //try
            //{
            //    /*FileStream*/ stream = new FileStream(fullFileName2, FileMode.Open);

            //    stream.Write(
            //       Encoding.UTF8.GetBytes("我的世界"),
            //        //Encoding.Unicode.GetBytes("我的世界"),
            //        //new byte[6] { 33, 34, 35, 36, 88, 90 }, //要写入的字节
            //        0,
            //        6  /*缓冲的大小*/);
            //    stream.Flush();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    stream.Dispose();
            //}



            using (FileStream stream = new FileStream(fullFileName2, FileMode.Open))
            {
                stream.Write(
                Encoding.UTF8.GetBytes("我的世界"),
                 //Encoding.Unicode.GetBytes("我的世界"),
                 //new byte[6] { 33, 34, 35, 36, 88, 90 }, //要写入的字节
                 0,
                 6  /*缓冲的大小*/);
                stream.Flush();
            }
            //使用  using完成，自动释放stream.Dispose(); using里的实现了IDisposable接口
            Console.WriteLine(111);
            // stream.Dispose();














            //StreamWriter writer=  new StreamWriter(fullfilrtime,FileMode.Open);










            ////我们默认使用的这个线程被称为主（primary）线程，或者启动线程。使用Thread.CurrentThread可以获取：
            //Thread current = Thread.CurrentThread;
            ////然后，可以获取线程的相关信息
            //Console.WriteLine(Thread.GetDomain().FriendlyName );
            //Console.WriteLine(current.ManagedThreadId);
            //Console.WriteLine(current.Priority);
            //Console.WriteLine(current.ThreadState);//线程状态
            //Console.WriteLine(current.IsThreadPoolThread);//线程池
            //Thread.Sleep(1000);
            ////让代码运行在多个线程中，就被称之为“多线程编程”，有时候又称之为并发
            //Console.WriteLine("1111111111111111111111");
            ////可以new一个工作线程：
            //Thread thread1 = new Thread(Process);
            //thread1.Start();
            //Console.WriteLine(Thread.GetDomain().FriendlyName);
            //Console.WriteLine(thread1.ManagedThreadId);
            //Console.WriteLine(thread1.Priority);
            //Console.WriteLine(thread1.ThreadState);//线程状态
            //Console.WriteLine(thread1.IsThreadPoolThread);//线程池





            for (int i = 0; i < 10; i++)
            {
               // Console.WriteLine($"{i}     ThreadId:{Thread.CurrentThread.ManagedThreadId}");//单线程
               //多线程
                new Thread(() => { Console.WriteLine($"{i}     ThreadId:{Thread.CurrentThread.ManagedThreadId}"); }).Start();

            }








        }

        public static void Process()
        {
             Console.WriteLine($"ThreadId:{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("ok");
        }


    }
}
