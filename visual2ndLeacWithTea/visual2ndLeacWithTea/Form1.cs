using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual2ndLeacWithTea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(button1.Size.Width.ToString());
            // button1.Enabled = false;
            // button1.Visible = false; 
            // button1.Size.Width = 30; //error
            button1.Size = new Size(30,30);
            button1.Location = new Point(12,1);
            int x = button1.Size.Width;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.AutoSize = false;
        }
    }
}
