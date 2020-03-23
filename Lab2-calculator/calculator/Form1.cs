using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double First_Number;
        string Operatie;

        public Form1()
        {
            InitializeComponent();
        }

        private bool nonNumberEntered = false;

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }



        private void n1_Click(object sender, EventArgs e)
        {
           
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }
        private void n2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }
        private void n3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }
        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }
        private void n6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void n7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }
        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void adunare_Click(object sender, EventArgs e)
        {
            First_Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operatie = "+";
        }

        private void scadere_Click(object sender, EventArgs e)
        {
            First_Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operatie = "-";
        }

        private void impartire_Click(object sender, EventArgs e)
        {
            First_Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operatie = "/";
        }

        private void radical_Click(object sender, EventArgs e)
        {
            double x;
            First_Number = Convert.ToDouble(textBox1.Text);
            x = Math.Sqrt(First_Number);
            textBox1.Text = Convert.ToString(x);
            First_Number = x;
          
        }


        private void inmultire_Click(object sender, EventArgs e)
        {
            First_Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operatie = "*";
        }

        private void rezultat_Click(object sender, EventArgs e)
        {
            double Second_Number = Convert.ToDouble(textBox1.Text);
            double Result;
            if(Operatie == "power")
            {
                Result = Math.Pow(First_Number, Second_Number);
                textBox1.Text = Convert.ToString(Result);
                First_Number = Result;
            }
            if(Operatie == "+")
            {
                Result = First_Number + Second_Number;
                textBox1.Text = Convert.ToString(Result);
                First_Number = Result;
            }
            if(Operatie == "-")
            {
                Result = First_Number - Second_Number;
                textBox1.Text = Convert.ToString(Result);
                First_Number = Result;
            }
            if(Operatie == "/")
            {
                Result = First_Number / Second_Number;
                textBox1.Text = Convert.ToString(Result);
                First_Number = Result;
            }
      
            if(Operatie == "*")
            {
                Result = First_Number * Second_Number;
                textBox1.Text = Convert.ToString(Result);
                First_Number = Result;
            }
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt32(textBox1.Text);
            double Result = 1;
        
            for (int i = 2; i <= x; i++)
            {
                Result *= i;
            }

            textBox1.Text = Convert.ToString(Result);

        }

        private void power_2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double Result = Math.Pow(x, 2);
            textBox1.Text = Convert.ToString(Result);
        }

        private void ln_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double Result = Math.Log10(x);
            textBox1.Text = Convert.ToString(Result);
        }

        private void power_y_Click(object sender, EventArgs e)
        {
            First_Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operatie = "power";
        }
    }
}
