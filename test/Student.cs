using System;
using System.Collections.Generic;

namespace test
{
    public class Student:Person
    {
        public Teacher Teacher { get; set; }
        public int Score { get; internal set; }
        internal List<Major> Majors { get; set; }

        public void Learn()
        {
            System.Console.WriteLine("我正在学习。。。111。");
        }
    }
    public static class ExtensionMethod//扩展方法
    {
        public static void Learn(this Student student)
        {
           Console.WriteLine("我正在学习。。。222。");
        }
    }
}
