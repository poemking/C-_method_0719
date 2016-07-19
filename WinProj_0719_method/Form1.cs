using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinProj_0719_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fact1(5);
        }
        private void fact1(int x) 
        {
            int total = 1;
            for (int i = 1; i <= x; i++) 
                total *= i;
             MessageBox.Show(total.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t = fact2(5);
            MessageBox.Show(t.ToString());

        }

        private int fact2(int x) 
        {
            int sum = 1;
            int cnt=1;
            do 
            {
                sum *= cnt;
                cnt++;
            } while (cnt <= x);
            return sum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            M1(d);
            MessageBox.Show("Call M1() "+d.ToShortDateString()); //所以d在這邊呼叫程式d+1完後, 挑出來d=沒加的 
        }
        //傳值呼叫 並不會影響原程式的值 做完就結束了
        private void M1(DateTime dt) 
        {
            dt = dt.AddDays(1);
            MessageBox.Show("M1 " +dt.ToShortDateString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            M2(ref d);
            MessageBox.Show("Call M2() " + d.ToShortDateString()); //ref後 d+1傳回來了
        }
        //ref呼叫 會影響原程式的值 
        private void M2(ref DateTime dt)
        {
            dt = dt.AddDays(1);
            MessageBox.Show("M2 " + dt.ToShortDateString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime d; //不給初始值
            M3(out d);  //會out吐出來程式做的d+2
            MessageBox.Show("Call M3() " + d.ToShortDateString());
        }
        //out呼叫 會影響原程式的值 
        private void M3(out DateTime dt)
        {
            dt = DateTime.Now.AddDays(2); //把d丟進來+2後回傳給程式
            MessageBox.Show("M3 " + dt.ToShortDateString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Gteet();
            Gteet("Bruce");
            Gteet("Bruce",TimeOfDay.Afternoon);
        }
        enum TimeOfDay {Morning, Afternoon, Evening }
        static void Gteet() 
        {
            Console.WriteLine("Hello");
        }
        static void Gteet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void Gteet(string name, TimeOfDay td)
        {
            string Message = "";
            switch (td) 
            {
                case TimeOfDay.Morning:
                    Message = "Good morning";
                    break;

                case TimeOfDay.Afternoon:
                    Message = "Good afternoon";
                    break;

                case TimeOfDay.Evening:
                    Message = "Good evening";
                    break;
            }
            Console.WriteLine(Message + " " + name);
        }
    }
}
