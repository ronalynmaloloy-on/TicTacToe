using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(btn_click);

                
                }
            }
        }

        int num = 0;
                
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {
                if (num % 2 == 0)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Maroon;
                    label1.Text = "O - turn";
                    getTheWinner();
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Chocolate;
                    label1.Text = "X - turn";
                    getTheWinner();
                }

                num++;
            }
        }

        bool win = false;
        
        public void getTheWinner()
        {
            if (!button1.Text.Equals("") && button1.Text.Equals(button2.Text) && button1.Text.Equals(button3.Text))
            {
                winEffect(button1, button2, button3);
                win = true;
            }
            if (!button4.Text.Equals("") && button4.Text.Equals(button5.Text) && button4.Text.Equals(button6.Text))
            {
                winEffect(button4, button5, button6);
                win = true;
            }
            if (!button7.Text.Equals("") && button7.Text.Equals(button8.Text) && button7.Text.Equals(button9.Text))
            {
                winEffect(button7, button8, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button4.Text) && button1.Text.Equals(button7.Text))
            {
                winEffect(button1, button4, button7);
                win = true;
            }
            if (!button2.Text.Equals("") && button2.Text.Equals(button5.Text) && button2.Text.Equals(button8.Text))
            {
                winEffect(button2, button5, button8);
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button6.Text) && button3.Text.Equals(button9.Text))
            {
                winEffect(button3, button6, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button5.Text) && button1.Text.Equals(button9.Text))
            {
                winEffect(button1, button5, button9);
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button5.Text) && button3.Text.Equals(button7.Text))
            {
                winEffect(button3, button5, button7);
                win = true;
            }

            
            if (AllBtnLength() == 9 && win == false)
            {
                label1.Text = "No Winner";
            }

        }

        public int AllBtnLength()
        {
            int allTextButtonsLength = 0;
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    allTextButtonsLength += c.Text.Length;
                }
            }
            return allTextButtonsLength;
        }

        public void winEffect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.OrangeRed;
            b2.BackColor = Color.OrangeRed;
            b3.BackColor = Color.OrangeRed;

            b1.ForeColor = Color.White;
            b2.ForeColor = Color.White;
            b3.ForeColor = Color.White;

            label1.Text = b1.Text + " Win";
        }

        

        private void buttonng_Click_1(object sender, EventArgs e)
        {
            num = 0;
            win = false;
            label1.Text = "Players";
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                }
            }
        }
    }
}
