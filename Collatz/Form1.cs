using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collatz
{
    public partial class Form1 : Form
    {
        public static   List<long> Collazt(long n)
        {
            List<long> data = new List<long>();
            data.Add(n);

            long resul = 0;


            while (true)
            {

                if (n == 1)
                {
                    break;
                }
                if ((n % 2) == 0)
                {
                    resul = n / 2;
                    n = resul;

                }
                else
                {
                    resul = (n * 3) + 1;
                    n = resul;
                }

                data.Add(n);
            }

            return data;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            

                long i = long.Parse(textBox1.Text);
                List<long> result = Collazt(i);

                for (int r = 0; r < result.Count; r++)
                {
                    dataGridView1.Rows.Add(result[r].ToString());
                }


                label3.Text = result.Count.ToString();


           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.Rows.Clear();
            label3.Text = "";

        }
    }
}
