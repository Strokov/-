using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Lesson7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         //   Console.WriteLine(dateTimePicker1.Value);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  string time1 = Convert.ToString(dateTimePicker1.Value).Remove(10);
           // Console.WriteLine(time1);
            try
            {
            string text1 = "\n                           Заявление на отпуск  \n \n\n\n\n\n\n               Прошу отправить меня в отпуск за свой счет ";
            string text2 = "\n    с " + Convert.ToString(dateTimePicker1.Value).Remove(10) + "  по  " + Convert.ToString(dateTimePicker2.Value).Remove(10) + ". \n\n\n\n\n\n\n";
            string text3 = "     Дата:   " + Convert.ToString(dateTimePicker3.Value).Remove(10);
            string text4 = "\n     ФИО:   " + textBox1.Text;
            string text5 = "\n                             Подпись:   ___________________";
            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);
            Console.WriteLine(text5);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
