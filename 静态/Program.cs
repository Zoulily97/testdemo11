using System;

namespace 静态
{
    class Person
    {

       
        private string _s1 = "我是实例成员s1";
        private static string _s2 = "我是静态成员s2";
        private string[] _courses = { "sql", "C#", "web", ".net" };
        public string this[int index]
        {
            get { return _courses[index]; }
            set { _courses[index] = value; }
        }

        public string S1  //实例成员
        {
            set { _s1 = value; }
            get { return _s1; }
        }
        public static string S2  //静态成员
        {
            set { _s2 = value; }
            get { return _s2; }
        }
        public void M1() //实例方法
        {
            Console.WriteLine(this.S1);
        }
        public static void M2()  //静态方法
        {
            Console.WriteLine(Person.S2);
        }
    }
}
namespace 静态
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.M1();//实例调用
            Person.M2();//静态调用
            Console.WriteLine(p[1]);//C#
        }
    }
}
