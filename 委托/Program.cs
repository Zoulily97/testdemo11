using System;

namespace 委托
{

    class Program
    {

        //定义委托：
        delegate void AnimalPlay(string name);

        //函数（以AnimalPlay型委托为参数）
        static void CircusStart(AnimalPlay animalPlay, string name)

        {

            //传入要调用的方法，和被调用的方法所需的参数，这里的参数必须与被调用方法的参数类型一致。

            Console.WriteLine("开始");

            animalPlay(name);

        }
        static void DogPlay(string greetings)

        {

            Console.WriteLine("{0},I am dogPlay! WangWang", greetings);
            //Good evening,I am dogPlay! WangWang

        }

        static void CatPlay(string greetings)

        {

            Console.WriteLine("{0},I am CatPlay! MiaoMiao", greetings);

        }

        static void Main(string[] args)
        {
            //在主函数中使用委托：
            //把函数DogPlay()转换为AnimalPlay型委托

            AnimalPlay deleDogPlay = new AnimalPlay(DogPlay);

            //把委托deleDogPlay传给函数CircusStart()

            CircusStart(deleDogPlay, "Good evening");

        }
    
    }
}
