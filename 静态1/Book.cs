using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态1
{
    public enum Type
    {
        Computer,
        Novel
    }
  public   class Book
    {
        private static int computer, novel;
        public static int count;
        public string title;
        public Type type;
        public double price;
        static  Book()
        {//静态构造函数，用来初始化静态成员

            computer = 3;
            novel = 2;
        }
        public Book(string title,Type type,double  price)
        {
            this.title = title;this.type = type;this.price = price;
            if (type ==Type.Computer)
            {
                computer++;
            }
            if (type==Type.Novel)
            {
                novel++;
            }
        }
        //静态方法
        public static int NumberComputer()
        {
            return computer;
        }
        //静态方法属性
        public static int NumberNovels
        {
            get { return novel; }
        }
    }
}
