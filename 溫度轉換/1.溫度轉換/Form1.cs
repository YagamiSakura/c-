using System;
using System.Windows.Forms;

namespace _1.溫度轉換
{
    public partial class Form1 : Form
    {
        int x = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cTemp, fTemp;
            if (x == 0)
            {
                cTemp = Convert.ToSingle(textBox2.Text);
                fTemp = cTemp * 9 / 5 + 32;
                label3.Text = Convert.ToString(fTemp)+"。F";
            }
            else
            {
                fTemp = Convert.ToSingle(textBox2.Text);
                cTemp = (fTemp - 32) / 1.8f;
                label3.Text = Convert.ToString(cTemp)+ "。C";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string C = "攝氏";
            string T = "華氏";
            if (x == 0)
            {
                x++;
                label1.Text = T;
                label2.Text = C;

            }
            else
            {
                x--;
                label1.Text = C;
                label2.Text = T;

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
     
        }
    }
}
