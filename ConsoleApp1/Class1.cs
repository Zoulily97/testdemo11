using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Linq_where_Study
    {


        public static void Execute()
        {
            var students = new List<Student1>();
            students.Add(new Student1("3", "陈元1"));
            students.Add(new Student1("2", "陈元2"));
            students.Add(new Student1("2", "陈元3"));
            students.Add(new Student1("32", "陈元4"));
            students.Add(new Student1("12", "陈元5"));
            students.Add(new Student1("3", "陈元6"));
            students.Add(new Student1("4", "陈元7"));
            students.Add(new Student1("5", "陈元8"));

            //取出ID包含3，1，2的student的name

            //结果： 陈元1，陈元2，陈元3，陈元6
            var listString1 = new List<string> { "3", "1", "2" };
            var result = from s in students
                         where s.Id == "3"|| s.Id == "1"||s.Id == "2"
                         select s;

            foreach (var item in result)
            {
                Console.WriteLine("name为：" + item.Name);
            }
        }
    }

    public class Student1
    {
        public Student1(string value, string name)
        {
            Id = value;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
