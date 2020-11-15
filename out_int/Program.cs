using System.Collections.Generic;

namespace out_int
{

    public class Animal { }
    public class Cat : Animal
    {
    }
    #region 自定义协变
    public interface ICustomerListOut<out T>
    {
        T Get();//T只能作为返回值，不能作为参数
    }
    public class CustomerListOut<T> : ICustomerListOut<T>
    {
        public T Get()
        {
            return default(T);
        }
    }
    #endregion



    // 在泛型前加in，而且T只能作为方法参数，不能作为返回值，这就是逆变

    #region 自定义逆变
    //在泛型接口的T前面有一个In关键字修饰，而且T只能方法参数，不能作为返回值类型，这就是逆变
    public interface ICustomerListIn<in T>
    {
        void Show(T t);//T只能作为参数，不能作为返回值
    }
    public class CustomerListIn<T> : ICustomerListIn<T>
    {
        public void Show(T t)
        {

        }
    }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {


            Animal animal1 = new Cat();
            // List<Animal> animals = new List<Cat>();//提示错误
            IEnumerable<Animal> list2 = new List<Cat>();//正确
                                                        //F12查看IEnumerable定义：//public interface IEnumerable<out T> : IEnumerable
                                                        //泛型前加out它代表的就是协变，T只能作为返回值，不能作为参数，这就是协变

            // 使用自定义协变
            ICustomerListOut<Animal> customerList1 = new CustomerListOut<Animal>();
            ICustomerListOut<Animal> customerList2 = new CustomerListOut<Cat>();
            //理解成后面实例的实际类型(Cat)必须是左边(Animal)内部扩展的（即继承了左边的类型或接口）(out)
            //这么理解：右边必须是左边的扩展(因为是out),即右边需要继承或者实现了左边；上方就是右边的Cat继承了左边的Animal；



            // 使用自定义逆变
            ICustomerListIn<Cat> customerListCat1 = new CustomerListIn<Cat>();
            ICustomerListIn<Cat> customerListCat2 = new CustomerListIn<Animal>();
            //理解成后面实例的实际类型(Animal)必须在左边(Cat)内部已经继承或者实现了的(in)
            //这么理解：右边必须是左边的基类或者实现的接口(因为是in),即右边需要左边继承或实现了它；上方就是右边的Animal被左边的Cat继承了；
            //in就是在括号内做参数，out就是出括号做返回值，这样来记。
        }
    }
}
