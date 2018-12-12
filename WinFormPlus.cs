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

namespace _1212WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked button");

            Debug.WriteLine($"a Text box = {Convert.ToInt32(aTxtBox.Text)}");

            Debug.WriteLine($"b Text box = {Convert.ToInt32(bTxtBox.Text)}");

            int a = Convert.ToInt32(aTxtBox.Text);

            int b = Convert.ToInt32(bTxtBox.Text);

            int c = a + b;

            resultLbl.Text = $"result = {c}";

        }
    }
}
