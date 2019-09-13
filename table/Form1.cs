using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace table
{
    public partial class Form1 : Form
    {
        int lvalue1 = 0, rvalue1 = 0;
        int lvalue2 = 0, rvalue2 = 0;
        int lvalue3 = 0, rvalue3 = 0;
        int lvalue4 = 0, rvalue4 = 0;
        int lvalue5 = 0, rvalue5 = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            marking.Text = "";
            answer.Text = "";
            mark = 0;
            recense.Text = "";
            ans1.Text = "";
            ans2.Text = "";
            ans3.Text = "";
            ans4.Text = "";
            ans5.Text = "";
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
            l5.Text = "";
            r1.Text = "";
            r2.Text = "";
            r3.Text = "";
            r4.Text = "";
            r5.Text = "";
            cheking.Visible = true;
        }

        int mark = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            mark = 0;
            if (left.Text == "" || right.Text == "")
                MessageBox.Show("Error! Input correct number");
            else
            {
                int leftborder = int.Parse(left.Text);
                int rightborder = int.Parse(right.Text);
                Random rnd = new Random();

                lvalue1 = rnd.Next(leftborder, rightborder);
                lvalue2 = rnd.Next(leftborder, rightborder);
                lvalue3 = rnd.Next(leftborder, rightborder);
                lvalue4 = rnd.Next(leftborder, rightborder);
                lvalue5 = rnd.Next(leftborder, rightborder);

                l1.Text = (lvalue1).ToString();
                l2.Text = (lvalue2).ToString();
                l3.Text = (lvalue3).ToString();
                l4.Text = (lvalue4).ToString();
                l5.Text = (lvalue5).ToString();

                rvalue1 = rnd.Next(leftborder, rightborder);
                rvalue2 = rnd.Next(leftborder, rightborder);
                rvalue3 = rnd.Next(leftborder, rightborder);
                rvalue4 = rnd.Next(leftborder, rightborder);
                rvalue5 = rnd.Next(leftborder, rightborder);

                r1.Text = (rvalue1).ToString();
                r2.Text = (rvalue2).ToString();
                r3.Text = (rvalue3).ToString();
                r4.Text = (rvalue4).ToString();
                r5.Text = (rvalue5).ToString();
            }
            
        }

        private void Cheking_Click(object sender, EventArgs e)
        {
            cheking.Visible = false;
            int multi1 = lvalue1 * rvalue1;
            int multi2 = lvalue2 * rvalue2;
            int multi3 = lvalue3 * rvalue3;
            int multi4 = lvalue4 * rvalue4;
            int multi5 = lvalue5 * rvalue5;

            if (ans1.Text == (multi1).ToString())
                mark++;
            if (ans2.Text == (multi2).ToString())
                mark++;
            if (ans3.Text == (multi3).ToString())
                mark++;
            if (ans4.Text == (multi4).ToString())
                mark++;
            if (ans5.Text == (multi5).ToString())
                mark++;
            marking.Text = "Right answers: ";
            answer.Text = mark.ToString();

            if (mark >= 4 && mark <= 5)
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 4);
                switch (value) {
                    case 1: recense.Text = "Good job!";
                        break;
                    case 2:
                        recense.Text = "Exellent result!";
                        break;
                    case 3:
                        recense.Text = "Not bad";
                        break;
                    case 4:
                        recense.Text = "Cool!";
                        break;
                }
                
            }
            else
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 6);
                switch (value)
                {
                    case 1:
                        recense.Text = "Study hard!";
                        break;
                    case 2:
                        recense.Text = "Be attentive!";
                        break;
                    case 3:
                        recense.Text = "Study more!";
                        break;
                    case 4:
                        recense.Text = "Try again";
                        break;
                    case 5:
                        recense.Text = "You need to work more and more!";
                        break;
                    case 6:
                        recense.Text = "Weakly...";
                        break;
                }
            }
        }
        
    }
}
