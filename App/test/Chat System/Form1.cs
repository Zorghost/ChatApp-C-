using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            messages1.Visible = false;
            calendar1.Visible = false;
            projects1.Visible = false;

            i++;
                if ( i % 2 == 0)
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true; 
            }
                   else if ( i % 2 == 1)
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            messages2.Visible = true;
            calendar1.Visible = false;
            projects1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            calendar1.Visible = true;
            messages2.Visible = false;
            projects1.Visible = false;

            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calendar1.Visible = false;
            messages2.Visible = false;
            projects1.Visible = true;
        }
    }
}
