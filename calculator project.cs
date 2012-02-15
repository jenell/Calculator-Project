using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //if button1_click=true...do this for every button?
        }
        

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string strText;
            strText = richTextBox1.Text;
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "";
            }
            else if (char.IsNumber(strText.Substring(strText.Length-1,1),0) == true  )
            {
                richTextBox1.Text = richTextBox1.Text + "+"; 
            }

        }

        //private void Substring(int p, int p_2)
        //{
        //    throw new NotImplementedException();
        //}

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string strText;
            strText = richTextBox1.Text;
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "";
            }
            else if (char.IsNumber(strText.Substring(strText.Length - 1, 1), 0) == true)
            {
                richTextBox1.Text = richTextBox1.Text + "*";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            string strText;
            strText = richTextBox1.Text;
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "";
            }
            else if (char.IsNumber(strText.Substring(strText.Length - 1, 1), 0) == true)
            {
                richTextBox1.Text = richTextBox1.Text + "-";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string strText;
            strText = richTextBox1.Text;
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "";
            }
            else if (char.IsNumber(strText.Substring(strText.Length - 1, 1), 0) == true)
                //strText.Length-1 -> taking # characters -1 which since it starts at 0, this gets last element
                // ,1 -> taking one element. 
                //if .Length-2, 2 -> would take last two elements
                // ),0 -> it is now looking at the 0th element
            {
                richTextBox1.Text = richTextBox1.Text + "/";
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //if this button is clicked, clear any text
            richTextBox1.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //calculate whatever is in textbox
            //while there is any multiplications, take # before symbol and take # after symbol and multiply
            //repeat for + , - , and /
            
            //x is 1 character in textbox
            //if within while indicating if is indigit 
            int x;
            string strText;
            strText = richTextBox1.Text;

            while (strText.Contains('/'))
            //for (x = 1; x <= strText.Length; x++)
            {
                x = strText.IndexOf('/');
                int start = goBack(strText, x);
                int end = goForward(strText, x);
                int answer =  Int32.Parse(strText.Substring(start,x-start)) / Int32.Parse(strText.Substring(x+1,end-1-x));
                strText = strText.Substring(0,start) + answer + strText.Substring(end);
            }
            while (strText.Contains('*'))
            //for (x = 1; x <= strText.Length; x++)
            {
                x = strText.IndexOf('*');
                int start = goBack(strText, x);
                int end = goForward(strText, x);
                int answer = Int32.Parse(strText.Substring(start, x - start)) * Int32.Parse(strText.Substring(x + 1, end - 1 - x));
                strText = strText.Substring(0, start) + answer + strText.Substring(end);
            }
            while (strText.Contains('+'))
            //for (x = 1; x <= strText.Length; x++)
            {
                x = strText.IndexOf('+');
                int start = goBack(strText, x);
                int end = goForward(strText, x);
                int answer = Int32.Parse(strText.Substring(start, x - start)) + Int32.Parse(strText.Substring(x + 1, end - 1 - x));
                strText = strText.Substring(0, start) + answer + strText.Substring(end);
            }
            while (strText.Contains('-'))
            //for (x = 1; x <= strText.Length; x++)
            {
                x = strText.IndexOf('-');
                int start = goBack(strText, x);
                int end = goForward(strText, x);
                int answer = Int32.Parse(strText.Substring(start, x - start)) - Int32.Parse(strText.Substring(x + 1, end - 1 - x));
                strText = strText.Substring(0, start) + answer + strText.Substring(end);
            }
            

            
            richTextBox1.Text = strText;

        }

        private int goBack(string s, int idx)
        {
            int i = idx - 1;
            while (i>=0 && Char.IsDigit(s.ElementAt(i))) {
                i--;
            }
            if (i < 0)
            {
                return 0;
            }
            return i+1;
        }

        private int goForward(string s, int idx)
        {
            int i = idx + 1;
            while (i <s.Length && Char.IsDigit(s.ElementAt(i))) {
                i++;
            }
            return i;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "1"; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "2"; 
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "3"; 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "4"; 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "5"; 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "6"; 
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "7"; 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "8"; 
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "9"; 
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "0";
            }
        }

    }
}
