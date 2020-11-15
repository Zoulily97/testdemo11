using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 静态1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Book[] bs = new Book[5];
        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type type = comboBox1.SelectedIndex == 0 ? Type.Computer : Type.Novel;

            double price = Convert.ToDouble(textPrice.Text);
            bs[Book.count] = new Book(textTitle.Text, type, price);
            Book.count++;
            labShow.Text = string.Format("添加成功：{0}本书", Book.count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labShow.Text = string.Format("\n计算机总数{0}", Book.NumberComputer());
            labShow.Text += string.Format("\n小说总数{0}", Book.NumberNovels);
            labShow.Text += string.Format("\n图书清单如下\n");
            foreach ( Book  b in bs)
            {
                if (b != null)
                {
                    labShow.Text += string.Format("{0}", b.title);
                }
            }
        }
    }
}
