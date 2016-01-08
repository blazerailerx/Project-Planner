using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Project_Planner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
            this.comboBox1.Visible = false;
            this.comboBox2.Visible = false;
            this.comboBox3.Visible = false;
            this.label1.Visible = false;
            this.label5.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label6.Visible = false;
            this.label4.Visible = false;
            this.label7.Visible = false;
            this.button4.Visible = false;
            this.dataGridView1.Visible = false;
            this.button6.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
            this.dataGridView2.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ihechi\Documents\ProjectPlanner.accdb";
            string query = "SELECT * FROM Project_Details";
            OleDbDataAdapter DA = new OleDbDataAdapter(query, connection);
            OleDbCommandBuilder CMD = new OleDbCommandBuilder(DA);
            DA.Fill(ProjectPlannerDataSet1.Project_Details);
            BlindingSource BlindSource = new BlindingSource();
            BlindSource.DataSource = this.ProjectPlannerDataSet1.Project_Details;
            this.dataGridView2.DataSource = BlindSource;
            this.dataGridView2.Visible = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectPlannerDataSet1.Project_Details' table. You can move, or remove it, as needed.
            this.project_DetailsTableAdapter.Fill(this.projectPlannerDataSet1.Project_Details);
            // TODO: This line of code loads data into the 'projectPlannerDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.projectPlannerDataSet.Employee_Details);
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ihechi\Documents\ProjectPlanner.accdb;
            Persist Security Info = False;";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow row = ProjectPlannerDataSet.Employee_Details.NewRow();
            row["Name"] = this.textBox1.Text;
            row["Dept"] = this.comboBox1.Text;
            row["Exp"] = this.comboBox2.Text;
            row["Team"] = this.comboBox3.Text;
            this.dBData.Employee_Details.Rows.Add(row);
            string connection = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ihechi\Documents\ProjectPlanner.accdb";
            string query = "SELECT * FROM Employee_Details";
            OleDbDataAdapter DA = new OleDbDataAdapter(query, connection);
            OleDbCommandBuilder CMD = new OleDbCommandBuilder(DA);
            DA.Update(ProjectPlannerDataSet.Employee_Details);
            this.ProjectPlannerDataSet.Employee_Details.Clear();
            MessageBox.Show("Employee Added Successfully");
            this.textBox1.Visible = false;
            this.textBox1.Visible = false;
            this.comboBox1.Visible = false;
            this.comboBox2.Visible = false;
            this.comboBox3.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.button4.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Ihechi\\Documents\\ProjectPlanner.accdb";
            string query = "SELECT * FROM Employee_Details";
            OleDbDataAdapter DA = new OleDbDataAdapter(query, connection);
            OleDbCommandBuilder CMD = new OleDbCommandBuilder(DA);
            DA.Fill(ProjectPlannerDataSet.Employee_Details);
            BindingSource BlindSource = new BlindingSource();
            BlindSource.DataSource = this.ProjectPlannerDataSet.Employee_Details;
            this.dataGridView1.DataSource = BlindSource;
            this.dataGridView1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           this.ProjectPlannerDataSet1.SchemaSerializationMode = SchemaSerializationMode.ExcludeSchema;
            DataRow row = ProjectPlannerDataSet1.Project_Details.NewRow();
            row["Name"] = this.textBox2.Text;
            row["Variant"]=this.comboBox3.Text
            row["StartDate"] = this.dateTimePicker1.Value;
            row["EndDate"] = this.dateTimePicker2.Value;
            row["ManMonths"] = this.textBox4.Text;
            this.ProjectPlannerDataSet.Project_Details.Rows.Add(row);
            string connection1 = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ihechi\Documents\ProjectPlanner.accdb";
            string query = "SELECT * FROM Project_Details";
            OleDbDataAdapter DA1 = new OleDbDataAdapter(query, connection1);
            OleDbCommandBuilder CMD = new OleDbCommandBuilder(DA1);
            DA1.Update(ProjectPlannerDataSet1.Project_Details);
            this.ProjectPlannerDataSet1.Project_Details.Clear();
            MessageBox.Show("Project Added Successfully");
            this.button6.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button6.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            this.comboBox1.Visible = true;
            this.comboBox2.Visible = true;
            this.comboBox3.Visible = true;
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.button4.Visible = true;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
