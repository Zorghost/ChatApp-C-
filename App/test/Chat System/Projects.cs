using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace Chat_System
{
    public partial class Projects : UserControl
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string sql = "Select * from Projects";
            DataAccess.ExecuteSQL(sql);
            DataTable dt = DataAccess.GetDataTable(sql);
            dataGridView1.DataSource = dt;
        }

        //show data table
        private void Projects_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //add new project
        private void button1_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into Projects (ProjectID, ProjectName, Students, Status) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "')";
            DataAccess.ExecuteQuery(txtQuery);
            LoadData();
        }

        //delete project
        private void button2_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from Projects where ProjectID='" + textBox1.Text + "'";
            DataAccess.ExecuteQuery(txtQuery);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
