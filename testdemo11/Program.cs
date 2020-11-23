using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace testdemo12
{
    class c1
    {
        public void P()
        {
            Console.WriteLine("C1111");
        }
    }
    class C0 : c1
    {
        public  /*new*/ virtual void P()
        {
            Console.WriteLine("COOO");
        }
    }
    class A : C0
    {
        public override void P()
        {
            base.P();
            Console.WriteLine("AAAA");
        }
    }

}
namespace testdemo11
{

    interface IEat
    {
        /*public*/
        void Eat();
    }
    public enum Role//权限管理
    {
        Student = 1,
        TeacherAssist = 2,
        TeamLeader = 4,
        DormitoryHead = 8
    }//注意所有枚举值必须是2的整数次方

    [AttributeUsage(AttributeTargets.Class)]
    public class MyAttribute : Attribute//继承特性
    {
        public int Version { get; set; }
    }


    public class OnlineAttribute : Attribute//继承特性
    {

        public int Version { get; set; }
        public string Name { get; set; }
        public OnlineAttribute( int age)
        {
            age = 5;
        }
    }


    //[My]
    [Flags]
    public enum Grade : short   //默认是int类型，现在是short类型
    {

        Excellent = 0,   //不写底层数据默认为O
        Passe = 1,      //默认以1的步长递增底层数据
        Failed = 2, //指定底层数据
        Good = 4

    }
    [My]
    public class Person
    {

        public static Person  GetBy()
        {
            return null;
        }
        internal void Eat()
        {
            throw new NotImplementedException();
        }

        internal void Reset()
        {
            throw new NotImplementedException();
        }
    }


    [Online(/*Version = 3*/5)]
    public class Student : Person, IEnumerable
    {




        public string Name { get; set; }




        //声明Grade属性

        private int _weight = 63;
        public Grade grade { get; set; }

        public int Age { get; set; }
        public double Score { get; set; }

        //学生角色权限
        public Role Roles { get; set; }//



        public static double operator -(Student a, Student b)//运算符
        {
            return a.Score - b.Score;
        }
        public static bool operator >(Student a, Student b)
        {
            //if (a.Age > b.Age)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return a.Age > b.Age;//运算符重载
        }
        public static bool operator <(Student a, Student b)
        {
            return a.Age < b.Age;//运算符重载
        }
        public static implicit operator Student(Teacher teacher)
        {
            return new Student { Age = teacher.Age };


        }

        [Obsolete("下一个版本会删除，请使用welcom方法"/*,true*/)]//默认是false// true 如果使用过时的元素将生成编译器错误
        public void Greet(string name)
        {
            Console.WriteLine($"你好呀是{name}");
        }

        public IEnumerator GetEnumerator()
        {
            //return null;
            return new Enumretor(this);
        }
        internal static  object[] students =
               {
               new Student (){Name="lw"},
               new Student (){Name="zl"}};
        struct Enumretor : IEnumerator
        {

            private object _current;
            private object[] _localStudents;
            private int _index;
            public object Current => _current;

            public Enumretor(Student student)
            {
                _localStudents = Student.students;
                _index = 0;
                _current = _localStudents[_index];
            }
            public bool MoveNext()
            {
                _index++;

                if (_index >= _localStudents.Length)
                {
                    return false;
                }
                _current = _localStudents[_index];
                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

    }
}
public class Teacher
{
    public double Score { get; set; }
    public int Age { get; set; }


}
public struct Bed//结构
{
    public int _number;
    public bool HasBooked;
    public double Price { get; set; }
    //public Bed()
    //{

    //}
    public Bed(int number)  //结构类型是 值类型 。而值类型要求其所有成员必须有值！
    {
        _number = number;
        Price = 99.9;
        HasBooked = false;

    }

}
namespace testdemo11
{
    public enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 6,
        Registered = 8
    }
    class User
    {
        public TokenManager Tokens { get; set; }

    }
    public class TokenManager
    {

        public void Add(Token token)
        {
            token = token | Token.Admin;



        }
        //void  Remove(User user)
        //{

        //}
        //Has(Token)
        //{

        //}
        public static explicit operator TokenManager(Token v)
        {
            throw new NotImplementedException();
        }

    }
    class Program
    {

      
        static void Sleep(Bed bed)
        {

        }
        static void grown(int age)
        {
            age = age + 5;
        }

        static void say( /*ref*/ string words)
        {
            words += "oh，yeah！";//words=words+"oh，yeah！"  //重新指向一个对象，不通过引用传递，就不会改变。要改变加ref
        }
        static void Main(string[] args)
        {





           // List<Student> students = new List<Student>
           //{
           //    new Student (){Name="lw"},
           //    new Student (){Name="zl"},
           //     new Student (){Name="leqw"},
           //     new Student (){Name="lew"},
           //    new Student (){Name="zle"}
           //};

            foreach (var item in new Student ())
            {

                Console.WriteLine(item);
            }
            //foreach
            //IEnumerator<Student> enumerator = Student.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    var item = enumerator.Current;
            //    Console.WriteLine(item);
            //}
























            //ArrayList books = new ArrayList();
            //Book book1 = new Book("C#", 311);
            //Book book2 = new Book("C#2", 33);
            //books.Add(book1);
            //books.Add(book2);
            //Console.WriteLine(book2.GetMessage());
            //Console.WriteLine(book2.Name);
            //Console.WriteLine(book1.Price);
            //Book a = (Book)books[0];
            //Console.WriteLine(a.Price);
            //Console.WriteLine();
            //foreach (var item in books)
            //{

            //    Console.WriteLine(item);
            //}

















            // List<Student> students = new List<Student>
            //{
            //    new Student (){Name="lw"},
            //    new Student (){Name="zl"}
            //};
            // for (int i = 0; i < students.Count; i++)
            // {
            //     Console.WriteLine(students[i].Name);
            // }
            // Console.WriteLine("------------");
            // foreach (var item in students)
            // {
            //     Console.WriteLine(item.Name);
            // }
            // foreach (var item in new Student())//只要实现了IEnumerable接口的就可以foreach
            // {

            // }
            ////

            //Dictionary<string, Student> students1 = new Dictionary<string, Student>()
            //{
            //    { "lw",new Student() },
            //   { "zl",new Student() },
            //};

            //foreach (var item in students1)
            //{
            //    Console.WriteLine(item.Key);
            //}





            //List<double> chengji1 = new List<double>() { 11.2, 34, 56 };
            //foreach (var item in chengji1)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < chengji1.Count; i++)
            //{
            //    Console.WriteLine(chengji1[i]);

            //}








            //List<double> chengji = new List<double>() { 11.2, 34, 56 };
            //Console.WriteLine(chengji[0]);
            //Console.WriteLine(chengji.Count());
            //chengji.BinarySearch(34);





            /*DoubleLinked*/

















            /*
           //反射主要应用
           Student ata = new Student();
           ata.Greet("刘伟");
           Console.WriteLine("反射主要应用");
           typeof(Student).GetMethod("Greet").Invoke(ata, new object[] { "刘伟" });//用反射调用方法
           */




            ////实例化一个StringBuilder对象
            //StringBuilder sb = new StringBuilder();
            ////一直往StringBuilder对象上添加（Append）字符串
            //sb.Append("源栈").Append("，").Append("欢迎您！");//连缀效果
            //                                           //sb.Append("，");
            //                                           //sb.Append("欢迎您！");



            //不要忘了使用ToString()将StringBuilder对象转换成字符串
            //string slagon4 = sb.ToString();
            //Console.WriteLine(slagon4);

            //string a2 = "源栈";
            //string b2 = "，";
            //string c2 = "欢迎您!";

            ////直接把abc连接起来
            //Console.WriteLine(string.Concat(a2, b2, c2));
            ////把abc用' '连接起来
            //string joined = string.Join(' ', a2, b2, c2);
            //Console.WriteLine(joined);   //注意空格：源栈 ， 欢迎您!

            //string.Concat('*',123, true) .Split('*', StringSplitOptions.RemoveEmptyEntries);




            //string aaa = "1d";
            //string bbb = "2d";
            //Console.WriteLine(string.Join("123", aaa, bbb));
            //Console.WriteLine(string.Concat('*', 123, true));


            ////
            //string slagon3 = "源栈欢迎您！！！";
            //Console.WriteLine(slagon3.IndexOf("！"));       //5
            //Console.WriteLine(slagon3.LastIndexOf("！"));   //7








            //

            //string yz = "源站";
            //string yz1 = "源站";//变量地址不一样，对象地址(堆地址)一样。
            //                  //引用类型，==运算符会比较两个对象的堆地址
            //Console.WriteLine(yz == yz1);//true


            //string center = "源栈", greet = "欢迎您";
            //string a1 = center + greet;
            //string b1 = $"{center}{greet}";
            //Console.WriteLine(a1 == b1);      //结果为true
            // Console.WriteLine(yz[1]);

            // 字符串池（string pool）
            //简单的说，在编译的时候（注意：是编译的时候，不是运行的时候），
            //编译器会设置一个字符串“池（pool）”。每次要实例化一个新字符串的时候，首先在池中进行检查：

            //搞得这么复杂，为什么不把string直接改成struct呢？
            //这是因为string有可能非常非常大，像我们之前讲过的，太大的对象就不适合放在栈中，以免占用宝贵的栈资源。

            //int aa = 1;
            //int bb = 1;
            //Console.WriteLine(aa == bb);//true




            //int a = 45;
            //grown(a);
            //Console.WriteLine(a);//45

            //string slagon1 = "123";
            //say(/*ref*/  slagon1);
            //Console.WriteLine(slagon1);//123    //slagon没有发生变化



            //string slagon = "@大神小班，拎包入住@";
            ////删除
            //Console.WriteLine(slagon.Remove(1));             //结果：@
            //Console.WriteLine(slagon.Remove(1, 1));          //结果：@神小班，拎包入住@
            //                                                 //插入
            //Console.WriteLine(slagon.Insert(2, "@"));        //结果：@大@神小班，拎包入住@
            //                                                 //替换
            //Console.WriteLine(slagon.Replace('大', '小'));   //结果：@小神小班，拎包入住@
            //                                               //截取
            //Console.WriteLine(slagon.Substring(1, 3));       //结果：大神小

            ////注意：slagon还是没有变//slagon本身没有改变
            //Console.WriteLine(slagon);                       //结果：@大神小班，拎包入住@
            //                                                 //所有的方法都不会改变作为参数传入的字符串slagan的值，因为字符串是immutable（不可变）的。
            //slagon = slagon.Remove(1);
            //Console.WriteLine(slagon);









            //ArrayList List = new ArrayList();
            //Object[] vs = new Object[2] { 123, "123是的" };
            //Console.WriteLine(vs[0]);
            //Console.WriteLine(vs[1]);




            //new Student().Greet("123");//Obsolete 提示一些已经过期

            //Console.WriteLine(Grade.Passe | Grade.Good);//里面是个枚举







            ////如何获取特性？//
            ///
            //Student student3 = new Student();
            //Attribute attribute = OnlineAttribute.GetCustomAttribute(
            //   typeof(Student),             //Student类上的
            //   typeof(OnlineAttribute)      //OnlineAttribute特性
            // );
            ////将基类的Attribute对象强转为子类
            //Console.WriteLine("特性");
            //Console.WriteLine(((OnlineAttribute)attribute).Version);




            /*在https://source.dot.net/中找到 Console.WriteLine(new Student()); 输出Student类名的源代码
                思考dynamic和var的区别，并用代码予以演示
                构造一个能装任何数据的数组，并完成数据的读写
                使用object改造数据结构栈（MimicStack），并在出栈时获得出栈元素*/


            //Console.WriteLine(new Student());
            //Console.WriteLine(typeof(Student).Name);  //Student //typeof 类型 传类名  编译时类型

            // var 在编译阶段已经确定类型，在初始化时候，必须提供初始化的值，
            ////而dynamic则可以不提供，它是在运行时才确定类型。
            //dynamic num1;
            //// var num2;// 报错：变量必须赋初值
            //num1 = "99";
            //Console.WriteLine(num1.GetType());//String 
            //Console.WriteLine(num1 - 98);// 未经处理的异常:   运算符“-”无法应用于“string”和“int”类型的操作数

















            ////装箱？
            //object wx1 = new Student();    //把new Student()的堆地址存到wx变量中
            //int k = 888;//888                  //把值888直接存放到变量i中
            //Console.WriteLine(k);
            //object o = 986;                //把986存到哪里？       //装箱
            //Console.WriteLine(o);//986
            //int i = (int)o;                 //拆箱
            //Console.WriteLine(i);//986   




            //Console.WriteLine(typeof(FlagsAttribute) is MemberInfo );
            ////直接使用Attribute的实例方法GetCustomAttribute()
            //Attribute attribute = FlagsAttribute.GetCustomAttribute(
            //    //传入要检索的类型：FlagsAttribute
            //    typeof(FlagsAttribute),
            //    //检索FlagsAttribute类上的AttributeUsageAttribute特性
            //    typeof(AttributeUsageAttribute));
            ////获得一个Attribute对象attribute
            //Console.WriteLine(
            //    //将其强制转换成AttributeUsageAttribute对象，
            //    //然后获得它的属性Inherited
            //    ((AttributeUsageAttribute)attribute).Inherited);













            ////反射
            //Student ata = new Student();
            //int weight = (int)ata.GetType().GetField("_weight", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(ata);
            //Console.WriteLine(weight);



            ////反射主要应用
            //Console.WriteLine("反射主要应用");
            //typeof(Student).GetMethod("Greet").Invoke(ata, new object[] { "刘伟" });























            {/*声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
                 声明一个令牌管理（TokenManager）类：
                使用私有的Token枚举_tokens存储所具有的权限
                 暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限
                 User类中添加一个Tokens属性，类型为TokenManager*/


                //    User zl1 = new User();
                // zl1.Tokens = (TokenManager)Token.Blogger;
                //zl1.Tokens= zl1.Tokens | (TokenManager)Token.Admin;

                //zl1.Tokens=zl1.
                //     TokenManager tokenManager = new TokenManager();
                // tokenManager.Add();





                //权限管理
                // | ：添加权限
                //^：剥夺权限
                //&：检测用户是否具有某项权限
                //Student zoulily = new Student
                //{
                //    Roles = Role.Student | Role.TeamLeader
                //};

                //zoulily.Roles = zoulily.Roles | Role.DormitoryHead;//添加
                //Console.WriteLine((zoulily.Roles & Role.TeamLeader) == Role.TeamLeader);//true
                //Console.WriteLine((zoulily.Roles & Role.DormitoryHead) == Role.DormitoryHead);//true
                //Console.WriteLine((zoulily.Roles & Role.DormitoryHead) == Role.TeacherAssist);//比较false
                //zoulily.Roles = zoulily.Roles ^ Role.DormitoryHead;//剥夺
                //Console.WriteLine((zoulily.Roles & Role.DormitoryHead) == Role.DormitoryHead);//false




                //Console.WriteLine(1 | 2);  // 01 | 10 => 11 (3)
                //Console.WriteLine(2 | 4);  // 010 | 100 => 110 (6) 
                //Console.WriteLine(1 & 2);  // 01 & 10 => 00 (0)
                //Console.WriteLine(2 & 4);  // 010 & 100 => 000 (0)
                //Console.WriteLine(1 ^ 2);  // 01 ^ 10 => 11 (3)

                ////
                //DateTime date2 = new DateTime(1, 1, 1, 8, 26, 0);
                //DateTime date3 = new DateTime(1, 1, 1, 7, 56, 0);
                //TimeSpan timeSpan = date2 - date3;
                //Console.WriteLine("两次时间相差" + timeSpan.TotalMinutes + "分钟");






                //内置类型
                //值类型 数值（整数int，小数float）
                //引用类型 string object Array

                //dynamic i = 23;
                //i = new Student();
                //Console.WriteLine(i+25);//使用dynamic标记的变量可以绕过C#的编译时（注意：仅仅是编译时）的类型检查 。
                ////运行时还是要报错











                //   testdemo12.C0 c0 = new testdemo12.C0();
                //   c0.P();//COOOO

                //   //2020111
                //   Student zl = new Student();
                //   zl.Roles = ((Role)zl.Roles | Role.TeacherAssist);
                //   Console.WriteLine(DayOfWeek.Monday.GetType());

                ////   int i = 31;
                //   Console.WriteLine(object.Equals(new Student(), new Student()));//False
                //   Console.WriteLine(object.ReferenceEquals(new Student(), new Student()));//false
                //   Console.WriteLine(new Student() == new Student());//false
                //   Console.WriteLine(Equals(new Bed(), new Bed()));//True
                //   Console.WriteLine(ReferenceEquals(new Bed(), new Bed()));//false
                //   Console.WriteLine(object.Equals(new Student(), new Person()));//false

                //   //
                //   string s1 = "feige";
                //   string s2 = "feige";
                //   Console.WriteLine(s1 == s2);//true
                //   Console.WriteLine(Equals(s1, s2));//true  特殊
                //                                     //
                //  //
                //   Console.WriteLine(s1.GetHashCode());
                //   Person wx = new Student();
                //   Console.WriteLine(wx.GetType().Name);//运行时类型
                //   Console.WriteLine(typeof(Person).Name);//typeof 类型 传类名  编译时类型
                //   Console.WriteLine(wx.ToString());
                //   Console.WriteLine(wx);
                //   //Tosttring 
                //   Console.WriteLine("tostring()");
                //   Console.WriteLine(DateTime.Now.ToString());//2020/11/2 10:48:03
                //   Console.WriteLine(new Student().ToString());//testdemo11.Student






                //枚举
                // Console.WriteLine(DateTime.Now.DayOfWeek);
                ////Grade grade = Grade.Passed;
                //Grade grade = Grade.Good;
                //switch (grade)
                //{
                //    case Grade.Excellent:
                //        //Console.WriteLine("good");
                //        //break;// yibanban
                //        Console.WriteLine("good");
                //        break;
                //    //case Grade.Passed:
                //      //  Console.WriteLine("yibanban");
                //       // break;
                //    case Grade.Failed:
                //        Console.WriteLine("xiaozhuzhu");
                //        break;
                //    default:
                //        Console.WriteLine($"...改动之后出现...{grade }未被处理");
                //        break;
                //}


                //string  引用类型 class  null 



                //TimeSpan span = new TimeSpan(TimeSpan.TicksPerMinute);
                //TimeSpan span = new TimeSpan(2, 10, 8);
                //TimeSpan span1 = DateTime.Now - new DateTime(2020, 9, 11);
                //Console.WriteLine(span1.Days);
                //Console.WriteLine(span1.TotalDays);
                //Console.WriteLine(span1.Hours);
                //Console.WriteLine(span1.TotalHours);


                //bool age1 = new Student { Age = 18 } > new Student { Age = 16 };
                //Console.WriteLine(age1);

                //double gap = new Student { Score = 98.5 } - new Student { Score = 90.0 };
                //Console.WriteLine(gap);


                //Console.WriteLine(DateTime.Now.ToLongDateString());
                //Console.WriteLine(DateTime.Now.ToLongTimeString());
                //Console.WriteLine(DateTime.Now.ToShortTimeString());
                //Console.WriteLine(DateTime.Now.ToShortDateString());
                //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd H m "));


                //Bed bed1;// 结构  变量为赋值，仍然可以使用   //值类型存放在栈中
                //bed1._number = 14;
                //Console.WriteLine(bed1._number);

                //Bed bed = new Bed();
                //Console.WriteLine(bed._number);//new 一下 (bed._number 赋了默认值

                //// Console.WriteLine(DateTime.MaxValue);


                //string now = "2010/10/29";
                //Console.WriteLine(DateTime.Parse(now));
                //if (DateTime.TryParse(now, out DateTime result))
                //{
                //    Console.WriteLine(result.Year);
                //}
                //else
                //{
                //    Console.WriteLine("cuowu");
                //}

                //Console.WriteLine(DateTime.Now);
                //DateTime date1 = new DateTime(2020, 10, 29, 12, 32, 22);
                //Console.WriteLine(date1.Hour);
                //Console.WriteLine((DateTime.Now.Hour));
                //Console.WriteLine(date1.Date);

                //int age = new Int32();
                //if(age is Int32)
                //{

                //}
                //Console.WriteLine(age);
                //long l = /*new Int64();*/6789;
                //l.CompareTo(age);











                //#region  抽象思考
                //Person person = null;
                //if (true/*时间到了*/)
                //{
                //    person.Eat();
                //}
                //person.Reset();

                //#endregion


            }
        }
    }
}
