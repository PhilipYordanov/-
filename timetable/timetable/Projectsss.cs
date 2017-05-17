using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class Projectsss : Form
    {
        public Projectsss()
        {
            InitializeComponent();
            textBox1.Visible = false;
            comboBox1.Visible = false;
        }

        private void Projectsss_Load(object sender, EventArgs e)
        {
            this.pROJECTTableAdapter.Fill(this.masterDataSet.PROJECT);
            dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Сигурни ли сте че искате да се върнете назад към главното меню ?";
            string caption = "Предупреждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateProjectsss form = new CreateProjectsss();
            form.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.Close();
            EditProject form = new EditProject(selectedRow);
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var f = new CreateProjectsss();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new CreateProjectsss();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Сигурни ли сте че искате да се върнете назад към главното меню ?";
            string caption = "Предупреждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Search(object sender, EventArgs e)
        {
            BindingSource bs = BindingDataForSearchEngine();
            bs.Filter = string
                .Format("CONVERT(" + dataGridView1.Columns[1].DataPropertyName
                + ", System.String) like '%"
                + textBox1.Text.Replace("'", "''")
                + "%'");
            dataGridView1.DataSource = bs;
        }

        private BindingSource BindingDataForSearchEngine()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1
                .DataSource;
            return bs;
        }

        private void SearchByStatus(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Затворени":
                    BindingSource bs = BindingDataForSearchEngine();
                    bs.Filter = string
                        .Format("CONVERT(" + dataGridView1.Columns[4].DataPropertyName
                        + ", System.String) like 'c'");
                    dataGridView1.DataSource = bs;
                    break;
                case "Отворени":
                    BindingSource bsks = BindingDataForSearchEngine();
                    bsks.Filter = string
                        .Format("CONVERT(" + dataGridView1.Columns[4].DataPropertyName
                        + ", System.String) like 'o'");
                    dataGridView1.DataSource = bsks;
                    break;
                default:
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem)
            {
                case "Име":
                    textBox1.Visible = true;
                    comboBox1.Visible = false;
                    break;
                case "Статус":
                    textBox1.Visible = false;
                    comboBox1.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
