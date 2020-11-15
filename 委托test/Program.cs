using System;

namespace 委托test
{
    class Program
    {

        public class Person
        {


            public int waternumber { get; set; } = 10;
            
            // 大水
            public static int GetWater(ProvideWater provideWater)
            {
                Person person = new Person();
                return provideWater(person);
            }


        }
        static int BigFriend(Person person)
        {
            Console.WriteLine("我是大朋友，我在打水");
            return person.waternumber += 3;
        }
        static int SmallFriend(Person person)
        {
            Console.WriteLine("我是小朋友，我在打水");
            return person.waternumber += 1;

        }

        //定义委托
        public delegate int ProvideWater(Person person);
        static void Main(string[] args)
        {
            ProvideWater provideWater = new ProvideWater(BigFriend);
            Console.WriteLine(Person.GetWater(provideWater));
            ProvideWater provideWater1= new ProvideWater(SmallFriend);
            Console.WriteLine(Person.GetWater(provideWater1));

        }
    }
}
