using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class BINGO : Form
    {
        public BINGO()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        { 
                var na = new Random();
                var NUM = na.Next(1, 6);

               if (NUM==1)
            {
                label2.Text = "B";
            } 
               else if (NUM==2)
            {
                label2.Text = "I";
            }
            else if (NUM == 3)
            {
                label2.Text = "N";
            }
            else if (NUM == 4)
            {
                label2.Text = "G";
            }
            else if (NUM == 5)
            {
                label2.Text = "O";
            }

            var na1 = new Random();
            var NUM1=na1.Next(1, 51);
            label1.Text = NUM1.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Honeydew;
            button1.Text = "O";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Honeydew;
            button2.Text = "O";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Honeydew && button2.BackColor == Color.Honeydew && button3.BackColor == Color.Honeydew && button4.BackColor == Color.Honeydew && button5.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button1.BackColor == Color.Honeydew && button7.BackColor == Color.Honeydew && button13.BackColor == Color.Honeydew && button19.BackColor == Color.Honeydew && button25.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button1.BackColor == Color.Honeydew && button6.BackColor == Color.Honeydew && button11.BackColor == Color.Honeydew && button16.BackColor == Color.Honeydew && button21.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button2.BackColor == Color.Honeydew && button7.BackColor == Color.Honeydew && button12.BackColor == Color.Honeydew && button17.BackColor == Color.Honeydew && button22.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button3.BackColor == Color.Honeydew && button8.BackColor == Color.Honeydew && button13.BackColor == Color.Honeydew && button18.BackColor == Color.Honeydew && button23.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button4.BackColor == Color.Honeydew && button9.BackColor == Color.Honeydew && button14.BackColor == Color.Honeydew && button19.BackColor == Color.Honeydew && button24.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button5.BackColor == Color.Honeydew && button10.BackColor == Color.Honeydew && button15.BackColor == Color.Honeydew && button20.BackColor == Color.Honeydew && button25.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button6.BackColor == Color.Honeydew && button7.BackColor == Color.Honeydew && button8.BackColor == Color.Honeydew && button9.BackColor == Color.Honeydew && button10.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button11.BackColor == Color.Honeydew && button12.BackColor == Color.Honeydew && button13.BackColor == Color.Honeydew && button14.BackColor == Color.Honeydew && button15.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button16.BackColor == Color.Honeydew && button17.BackColor == Color.Honeydew && button18.BackColor == Color.Honeydew && button19.BackColor == Color.Honeydew && button20.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button21.BackColor == Color.Honeydew && button22.BackColor == Color.Honeydew && button23.BackColor == Color.Honeydew && button24.BackColor == Color.Honeydew && button25.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else if (button5.BackColor == Color.Honeydew && button9.BackColor == Color.Honeydew && button13.BackColor == Color.Honeydew && button17.BackColor == Color.Honeydew && button21.BackColor == Color.Honeydew)
            {
                MessageBox.Show("El mejor grupo 20/20");
                Close();
            }
            else
            {
                MessageBox.Show("Aun no haz alcanzado el BINGO");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Honeydew;
            button3.Text = "O";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Honeydew;
            button4.Text = "O";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Honeydew;
            button5.Text = "O";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Honeydew;
            button6.Text = "O";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Honeydew;
            button7.Text = "O";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Honeydew;
            button8.Text = "O";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Honeydew;
            button9.Text = "O";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Honeydew;
            button10.Text = "O";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Honeydew;
            button11.Text = "O";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Honeydew;
            button12.Text = "O";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Honeydew;
            button13.Text = "O";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Honeydew;
            button14.Text = "O";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Honeydew;
            button15.Text = "O";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Honeydew;
            button16.Text = "O";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Honeydew;
            button17.Text = "O";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Honeydew;
            button18.Text = "O";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Honeydew;
            button19.Text = "O";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.Honeydew;
            button20.Text = "O";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Honeydew;
            button21.Text = "O";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.Honeydew;
            button22.Text = "O";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.Honeydew;
            button23.Text = "O";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Honeydew;
            button24.Text = "O";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.Honeydew;
            button25.Text = "O";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
