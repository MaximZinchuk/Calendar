using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Week
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресение
        }
        int day = 0;
        int mounth = 1;
        int year = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if()
                day = Convert.ToInt32(textBox1.Text);
                if (day > 30)
                {
                    day = 30;
                    textBox1.Text = "" + day;
                }
            }
            catch (Exception)
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = "" + day;
                }
            }
            LableUpdate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if()
                mounth = Convert.ToInt32(textBox2.Text);
                if (mounth > 12)
                {
                    mounth = 12;
                    textBox2.Text = "" + mounth;
                }
                if (mounth < 1)
                {
                    mounth = 1;
                    textBox2.Text = "" + mounth;
                }
            }
            catch (Exception)
            {
                if (textBox2.Text != "")
                {
                    textBox2.Text = "" + mounth;
                }
            }
            LableUpdate();
        }
        enum Monthes
        {
            незно,
            Января,
            Февраля,
            Марта,
            Апреля,
            Мая,
            Июня,
            Июля,
            Августа,
            Сентября,
            Отября,
            Ноября,
            Декабря
        }
        public void LableUpdate() {
            int AllDays = ((year * 360) + (mounth * 30)) + day;
            label1.Text = "" + (Week)(AllDays % 7) + ", " + day + " " + (Monthes)mounth + " " + year + " года";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if()
                year = Convert.ToInt32(textBox3.Text);
                if (year > 2030)
                {
                    year = 2030;
                    textBox3.Text = "" + year;
                }
            }
            catch (Exception)
            {
                if (textBox3.Text != "")
                {
                    textBox3.Text = "" + year;
                }
            }
            LableUpdate();
        }
    }
}
