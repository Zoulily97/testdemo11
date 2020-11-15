using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdemo11
{
   public  class Book
    {
        private string _name;
        private int _price;

       
        public Book(string name,int price)
        {
            this.Price = price;
            this.Name = name;
        }

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public  string GetMessage()
        {
            return this.Name; 
        }

    }
}
