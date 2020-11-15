﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace test
{
    class Program
    {

        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }
        static void Exam(IEnumerable<int> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }





        static void AICaculate(int a, int b, Action<int, int> opt)
        {
            Console.WriteLine("I'm AI caculator, let me try:");
            //Add(a, b);
            //Multiple(a, b);

            opt(a, b);
        }
        static void Add(int a, int b)
        {
            Console.WriteLine($"it's so easy, {a}+{b}={a + b}");
        }

        static void Multiple(int a, int b)
        {
            Console.WriteLine($"I can I can, {a}*{b}={a * b}");
        }
        static void Main(string[] args)
        {
















            Teacher fg = new Teacher { Name = "大飞哥",Id=1 };
            Teacher fish = new Teacher { Name = "小鱼",Id=2 };
            Teacher waiting = new Teacher { Name = "诚聘", Age = 0 };
            IEnumerable<Teacher> teachers = new List<Teacher> { fg, fish, waiting };

            Major csharp = new Major { Name = "C#", Teacher = fg,TeacherId=1 };
            Major SQL = new Major { Name = "SQL", Teacher = fg , TeacherId = 1 };
            Major Javascript = new Major { Name = "Javascript", Teacher = fg, TeacherId = 1 };
            Major UI = new Major { Name = "UI", Teacher = fish , TeacherId = 2};
            IEnumerable<Major> majors = new List<Major> { csharp, SQL, Javascript, UI };

            IList<Student> students = new List<Student>
    {
        new Student{Score = 98, Name = "屿", Majors=new List<Major>{csharp,SQL } },
        new Student{Score = 86, Name = "行人", Majors=new List<Major>{Javascript, csharp, SQL} },
        new Student{Score = 78, Name = "王平", Majors=new List<Major>{csharp}},
        new Student{Score = 89, Name = "王枫", Majors=new List<Major>{Javascript, csharp, SQL,UI}},
        new Student{Score = 98, Name = "蒋宜蒙", Majors=new List<Major>{Javascript, csharp}},
    };

            //var result = from m in majors
            //             join t in teachers
            //              on m.TeacherId equals t.Id
            //             //where t.Name == "小鱼"
            //             select new  {
            //                 t.Id,
            //                 teachername=t.Name,
            //                 majorsname=m.Name  

            //};

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Id}=={item.teachername}=={item.majorsname}");
            //}
            var result = from s in students
                         where s.Score > 60
                         select s;
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);//"屿"  "蒋宜蒙"
                Console.WriteLine("  where s.Score > 60");
            }
            if (true)
            {//王
                result = from r in result.ToList()
                         where r.Name.StartsWith("王")
                         select r;

            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("  where s.Score > 60   --- where r.Name.StartsWith王");
            }

            students.Add(new Student
            {
                Score = 89,
                Name = "王枫2",
                Majors = new List<Major> { Javascript, csharp, SQL, UI }
            });
            if (true)
            {
                result = from r in result
                         where r.Majors.Count() > 3
                         select r;
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Name );
                Console.WriteLine("  where s.Score > 60   --- where r.Name.StartsWith王 ---where r.Majors.Count() > 3");
            }






            IEnumerable<int> numbers = GetSingleDigitNumbers();//numbers  IEnumerable的实例

            //Exam(new List<Student>());
            //Exam(new Queue<Student>());
            // Exam(GetSingleDigitNumbers());
            Exam(numbers);






            //Func<int,int> squre = (a) =>
            //{
            //    return a * a;
            //};
            //Func<int, int> squre = a => a * a; ;
            //squre(3);
            //Console.WriteLine(squre(3));


            //
            Action<int, int> opt = Add;
            opt(2, 3);//it's so easy, 2+3=5


            Action<int, int> opt1 = delegate (int a, int b)
            {
                Console.WriteLine($"it's so easy, {a}/{b}={a /b}");
            };
            opt1(20, 30); //it's so easy, 20/30=0

            //lamda表达式
            Action<int, int> opt2 = (a, b) =>
            {
                Console.WriteLine($"it's so easy, {a}+{b}={a + b}");
            };
            opt2(2, 33);//it's so easy, 2+33=35




            //匿名方法
            //Caculate ai = delegate (int x, int y)
            //{
            //    Console.WriteLine($"just a piece of cake: {x}/{y}={x / y}");
            //};
            //ai(8, 3);

            //Lambda表达式，匿名方法
            AICaculate(8, 3, (a, b) =>
              {
                  Console.WriteLine($"I can I can, {a}%{b}={a % b}");
              });


            //Lambda简写//可以不指定参数类型
            Action<string, string> d = (x, y) => { Console.WriteLine(x + "欢迎您，" + y); };
            d("小张", "重庆之声");// 小张欢迎您，重庆之声

            //Lambda简写,一行方法体实现，可以不用{ }
            //省略掉花括号
            Action d1 = () => Console.WriteLine("源栈欢迎您");
            d1();//源栈欢迎您

            //Lambda简写 一个参数，可以不用（）；没有参数，还是要有一个空括号
            Action<string> d2 = x => Console.WriteLine(x + "欢迎您");
            d2("zouli");//zouli欢迎您

            //而且不能写return
            //要return就必须要花括号{}
            Func<int, int> square2 = a => { return a * a; };
            Console.WriteLine(square2(2));//4
            Func<int, int> square1 = a => a * a;
            Console.WriteLine(square1(3));//9



            //匿名委托 
            //AICaculate(8, 3, delegate (int a, int b)
            //  {
            //      Console.WriteLine($"I can I can, {a}%{b}={a % b}");
            //  });



            //Action<int,int> opt= Add;
            //opt(2, 3);

            //Caculate caculate = Add;
            //Add(3, 2);
            //caculate(3, 3);



            //
            //new List<int>().Any




            //对象对象之间关系，通过属性
            //Student zl = new Student() { Name="邹林"};
            //Student zl1 = new Student() { Name = "邹林" };
            //Teacher fg = new Teacher() { Name="自由飞"};
            //zl.Teacher = fg;
            //Console.WriteLine(zl.Teacher.Name);
            //IList<Student> a= new IList<Student> { zl, zl1 };




            //扩展
            //Student zl = new Student();
            //zl.Learn();

        }




    }

    // //像声明一个类一样声明一个委托
    //但定义了这个委托的返回void类型，接受两个int类型的参数
    public delegate void Caculate(int a, int b);

    public delegate void Opt(string a, int b);
    public delegate void Optt<T1, T2>(T1 a, T2 b);

}
