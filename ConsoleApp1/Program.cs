using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal eat");
        }
    }

    public class Cat : Animal
    {
        public new void Eat()
        {
            Console.WriteLine("Cat eat");
        }
        //public override void Eat()//出错
        //{
        //    base.Eat();
        //}
    }
    public class Student
    {
        
        private int _weight;
        public Student(int weight)
        {
            _weight = weight;
        }
        public int ? NL { get; set; }//可空类型
        public string Name { get; set; }
    }

    //在普通类上加一个<T>就诞生了泛型类
    public class Generic<T>
    {
        //注意T[]，不是int[]或者string[]
        internal T[] array;
    }

}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

















            Linq_where_Study.Execute();

            Student le = null;
            Console.WriteLine(le?.Name?? "无名氏");



            Student student1 = new Student(23);
            student1.NL = 12;
            Console.WriteLine(student1.NL.GetValueOrDefault());//12

          //  int nl2=new Int32();
            int? nl = new Nullable<int>(40);




            Console.WriteLine(typeof(Generic<int>) == new Generic<int>().GetType());//true
            Console.WriteLine(typeof(Generic<Student>) == new Generic<Student>().GetType());//true
            Console.WriteLine(typeof(Generic<int>) == new Generic<Student>().GetType());//false





















            DoubleLinked node1 = new DoubleLinked();
            DoubleLinked node2 = new DoubleLinked();
            node1.AddAfter(node2);
            Console.WriteLine(node1.Next==node2);//true


            Student zjq = new Student(63);
            Type typeInfo = zjq.GetType();
            Type typeInfo1 = typeof(Student);

            FieldInfo onWeight = typeInfo.GetField("_weight",   BindingFlags.NonPublic | BindingFlags.Instance);
            //必须指定这个字段的名字
            //1. 说明这个字段是非公共的，实例的
            //2. BindingFlags属于名称空间System.Reflection;

            Animal a = new Animal();// 
            a.Eat();//Animal

            Animal ac = new Cat();
            ac.Eat(); //Animal

           Cat c = new Cat();
            c.Eat();//cat
        }
    }
}
