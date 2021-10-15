using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
    public partial class Form1 : Form
    {
        private bool x;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
           
        }
       
       
        private void result()
        {// horizontal check for win
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text == "X")
            {
                MessageBox.Show("X won");
                this.Close();
            }
            else
           if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "X")
            {
                MessageBox.Show("X won");
                this.Close();
            }
            else
           if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == "X")
            {
                MessageBox.Show("X won");
                this.Close();
            }
            else
           if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text == "O")
            {
                MessageBox.Show("O won");
                this.Close();
            }
            else
           if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "O")
            {
                MessageBox.Show("O won");
                this.Close();
            }
            else
           if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == "O")
            {
                MessageBox.Show("O won");
                this.Close();
            }
            // vertical check for win
            else
           if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == "X")
            {
                MessageBox.Show("X won");
                this.Close();
            }
            else
           if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text == "X")
            {
                MessageBox.Show("X won");
                this.Close();
            }

            else
           if (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text == "X")
            {
                MessageBox.Show("X won");
                this.Close();
            }
            else
           if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == "O")
            {
                MessageBox.Show("O won");
                this.Close();
            }
            else
           if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text == "O")
            {
                MessageBox.Show("O won");
                this.Close();
            }
            else
           if (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text == "O")
            {
                MessageBox.Show("O won");
                this.Close();
            }
            else //diagnal check for win
           if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == "X")
            {
                MessageBox.Show("X won");
                this.Close();
            }
            else
           if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == "O")
            {
                MessageBox.Show("O won");
                this.Close();
            }
            else
           if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text == "X")
            {
                MessageBox.Show("X won");
                this.Close();
            }
            else
           if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text == "O")
            {
                MessageBox.Show("O won");
                this.Close();
            }
            else
                if (count == 9)
            {
                MessageBox.Show("It is a Tie");
                this.Close();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (x && count%2==0)
            {
                button1.Text = "X";
                count++;
              
            }
            else
           if(x&& count % 2 != 0)
            {
                button1.Text = "O";
                count++;
            }
            else
           if(!x && count % 2 == 0)
            {
                button1.Text = "O";
                count++;

            }
            else
           if(!x && count % 2 != 0)
            {
                button1.Text = "X";
                count++;
            }

         
            result();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            x = true;
            buttonX.Enabled = false;
            buttonCircle.Enabled = false;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            x = false;
            buttonX.Enabled = false;
            buttonCircle.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x && count % 2 == 0)
            {
                button2.Text = "X";
                count++;

            }
            else
            if (x && count % 2 != 0)
            {
                button2.Text = "O";
                count++;
            }
            else
            if (!x && count % 2 == 0)
            {
                button2.Text = "O";
                count++;

            }
            else
            if (!x && count % 2 != 0)
            {
                button2.Text = "X";
                count++;
            }
            result();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (x && count % 2 == 0)
            {
                button3.Text = "X";
                count++;

            }
            else
            if (x && count % 2 != 0)
            {
                button3.Text = "O";
                count++;
            }
            else
            if (!x && count % 2 == 0)
            {
                button3.Text = "O";
                count++;

            }
            else
            if (!x && count % 2 != 0)
            {
                button3.Text = "X";
                count++;
            }
            result();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (x && count % 2 == 0)
            {
                button4.Text = "X";
                count++;

            }
            else
            if (x && count % 2 != 0)
            {
                button4.Text = "O";
                count++;
            }
            else
            if (!x && count % 2 == 0)
            {
                button4.Text = "O";
                count++;

            }
            else
            if (!x && count % 2 != 0)
            {
                button4.Text = "X";
                count++;
            }
            result();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (x && count % 2 == 0)
            {
                button5.Text = "X";
                count++;

            }
            else
            if (x && count % 2 != 0)
            {
                button5.Text = "O";
                count++;
            }
            else
            if (!x && count % 2 == 0)
            {
                button5.Text = "O";
                count++;

            }
            else
            if (!x && count % 2 != 0)
            {
                button5.Text = "X";
                count++;
            }
            result();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (x && count % 2 == 0)
            {
                button6.Text = "X";
                count++;

            }
            else
            if (x && count % 2 != 0)
            {
                button6.Text = "O";
                count++;
            }
            else
            if (!x && count % 2 == 0)
            {
                button6.Text = "O";
                count++;

            }
            else
            if (!x && count % 2 != 0)
            {
                button6.Text = "X";
                count++;
            }
            result();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (x && count % 2 == 0)
            {
                button7.Text = "X";
                count++;

            }
            else
            if (x && count % 2 != 0)
            {
                button7.Text = "O";
                count++;
            }
            else
            if (!x && count % 2 == 0)
            {
                button7.Text = "O";
                count++;

            }
            else
            if (!x && count % 2 != 0)
            {
                button7.Text = "X";
                count++;
            }
            result();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (x && count % 2 == 0)
            {
                button8.Text = "X";
                count++;

            }
            else
            if (x && count % 2 != 0)
            {
                button8.Text = "O";
                count++;
            }
            else
            if (!x && count % 2 == 0)
            {
                button8.Text = "O";
                count++;

            }
            else
            if (!x && count % 2 != 0)
            {
                button8.Text = "X";
                count++;
            }
            result();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (x && count % 2 == 0)
            {
                button9.Text = "X";
                count++;

            }
            else
            if (x && count % 2 != 0)
            {
                button9.Text = "O";
                count++;
            }
            else
            if (!x && count % 2 == 0)
            {
                button9.Text = "O";
                count++;
            }
            else
            if (!x && count % 2 != 0)
            {
                button9.Text = "X";
                count++;
            }
            result();
        }

      
    }
}
