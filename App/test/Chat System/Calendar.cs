using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using Database;

namespace Chat_System
{
    public partial class Calendar : UserControl
    {
       
        public Calendar()
        {
            InitializeComponent();
        }

      
       
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox4.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar3_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Now.AddDays(-31);
            monthCalendar1.SelectionEnd=DateTime.Now.AddDays(-31);
            monthCalendar3.SelectionStart = DateTime.Now.AddDays(31);
            monthCalendar3.SelectionEnd = DateTime.Now.AddDays(31);
        }

      
        
        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            button2.Visible = false;
        }
       
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
           
            button2.Visible = true;
            textBox1.Text = monthCalendar2.SelectionStart.ToString("dd/M/yyyy");
        }
        
        private void monthCalendar3_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            button2.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            string txtquery = "insert into Calender(Date,Location,Time,Decriptions)values('"+textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox4.Text+"')";
            DataAccess.ExecuteSQL(txtquery);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
            monthCalendar3.Visible = false;
            dataGridView1.Visible = true;

           string sql = "Select * from Calender";
            DataAccess.ExecuteSQL(sql);
            DataTable dt = DataAccess.GetDataTable(sql);
            dataGridView1.DataSource = dt;
        }
    }
}
