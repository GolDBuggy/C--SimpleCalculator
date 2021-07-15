using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.ders_hesap_makinesi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sonuc;
        double sayi;
        string islem;

        

        void number()
        {
            if (textBox1.Text != "")
            {
                sayi = Convert.ToDouble(textBox1.Text);
                label1.Text = sayi.ToString() + islem.ToString();
                textBox1.Text = "";
               
             
            }
            else
            {
                label1.Text = "Sayı Bos Olamaz";
            }




            }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }

            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }

            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }

            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(textBox1.Text);
            islem = "+";
            number();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(textBox1.Text);
            islem = "-";
            number();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(textBox1.Text);
            islem = "/";
            number();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(textBox1.Text);
            islem = "x";
            number();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    sonuc = sayi + Convert.ToDouble(textBox1.Text);
                    label1.Text =sayi.ToString()+"+"+textBox1.Text+"="+sonuc.ToString();
                    textBox1.Text = "";
                    break;

                case "-":
                    sonuc = sayi - Convert.ToDouble(textBox1.Text);
                    label1.Text = sayi.ToString() + "-" + textBox1.Text + "=" + sonuc.ToString();
                    textBox1.Text = "";
                    break;

                case "/":
                    sonuc = sayi / Convert.ToDouble(textBox1.Text);
                    label1.Text = sayi.ToString() + "/" + textBox1.Text + "=" + sonuc.ToString();
                    textBox1.Text = "";
                    break;

                case "x":
                    sonuc = sayi * Convert.ToDouble(textBox1.Text);
                    label1.Text = sayi.ToString() + "x" + textBox1.Text + "=" + sonuc.ToString();
                    textBox1.Text = "";
                    break;

                
            }
            listBox1.Items.Add(label1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Text == "Past")
            {
                groupBox1.Visible = true;
                this.Size = new Size(591, 461);
                button17.Text = "Hide Past";
            }
            else
            {
                groupBox1.Visible = false;
                this.Size = new Size(340, 461);
                button17.Text = "Past";
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
