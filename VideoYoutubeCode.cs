using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class myWindow : Form
    {
        public myWindow()
        {
            InitializeComponent();
        }

 

        private void plusBtn_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void myWindow_Load(object sender, EventArgs e)
        {

        }

        private void GetAAndB(out int a, out int b)
        {
            a = Convert.ToInt32(firstNumberTxtBox.Text);

            b = Convert.ToInt32(secondNumberTxtBox.Text);

            Debug.WriteLine($"Numbers from text box a = {a} b = {b}");

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            // +
            int a, b;

            GetAAndB(out a, out b);

            int c = a + b;

            resultLbl.Text = $"Result = {c}";

        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            // -
            int a, b;

            GetAAndB(out a, out b);

            int c = a - b;

            resultLbl.Text = $"Result = {c}";
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            // *
            int a, b;

            GetAAndB(out a, out b);

            int c = a * b;

            resultLbl.Text = $"Result = {c}";
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            // div
            int a, b;

            GetAAndB(out a, out b);

            if (b == 0)
            {
                resultLbl.Text = "You cannot divide by zero";
            }
            else
            {

                int c = a / b;

                resultLbl.Text = $"Result = {c}";
            }
        }
    }
}
