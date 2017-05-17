using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class EmployeeData : Form
    {
        public EmployeeData()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeData_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.masterDataSet.EMPLOYEES);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedRow = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.Close();
            Edit form = new Edit(selectedRow);
            form.ShowDialog();
            var newEmployeeForm = new EmployeeData();
            newEmployeeForm.ShowDialog();
        }

        private BindingSource BindingDataForSearchEngine()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1
                .DataSource;
            return bs;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchByName();
        }

        private void SearchByName()
        {
            BindingSource bs = BindingDataForSearchEngine();
            bs.Filter = string
                .Format("CONVERT(" + dataGridView1.Columns[2].DataPropertyName
                + ", System.String) like '%"
                + textBox1.Text.Replace("'", "''")
                + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchByEGN();
        }

        private void SearchByEGN()
        {
            BindingSource bs = BindingDataForSearchEngine();
            bs.Filter = string
                .Format("CONVERT(" + dataGridView1.Columns[1].DataPropertyName
                + ", System.String) like '%"
                + textBox2.Text.Replace("'", "''")
                + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            SearchByPossition();
        }

        private void SearchByPossition()
        {
            BindingSource bs = BindingDataForSearchEngine();
            bs.Filter = string
                .Format("CONVERT(" + dataGridView1.Columns[5].DataPropertyName
                + ", System.String) like '%"
                + textBox3.Text.Replace("'", "''")
                + "%'");
            dataGridView1.DataSource = bs;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.FillBy(this.masterDataSet.EMPLOYEES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchingParam();
        }

        private void SearchingParam()
        {
            switch (comboBox1.SelectedItem)
            {
                case "Име":
                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    break;
                case "ЕГН":
                    textBox1.Visible = false;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    break;
                case "Позиция":
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewEmployee form = new CreateNewEmployee();
            form.ShowDialog();
            
        }
    }
}

