using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Fibonacci(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                if (n >= 0)
                {
                    string result = "دنباله فیبوناچی تا " + n + "\n";
                    for (int i = 0; i < n; i++)
                    {
                        result += Fibonacci(i) + " ";
                    }
                    MessageBox.Show(result, "نتیجه");
                }
                else
                {
                    throw new Exception("لطفا یک عدد مثبت وارد کنید.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا");
            }
        }
    }
}
