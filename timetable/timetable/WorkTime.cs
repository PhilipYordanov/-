using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class WorkTime : Form
    {
        public WorkTime()
        {
            InitializeComponent();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.masterDataSet.EMPLOYEES);
            // TODO: This line of code loads data into the 'masterDataSet.PROJECT_HOURS' table. You can move, or remove it, as needed.
            this.pROJECT_HOURSTableAdapter.Fill(this.masterDataSet.PROJECT_HOURS);
            // TODO: This line of code loads data into the 'masterDataSet.PROJECT_MONTHS' table. You can move, or remove it, as needed.
            this.pROJECT_MONTHSTableAdapter.Fill(this.masterDataSet.PROJECT_MONTHS);
            // TODO: This line of code loads data into the 'masterDataSet.PROJECT' table. You can move, or remove it, as needed.
            this.pROJECTTableAdapter.Fill(this.masterDataSet.PROJECT);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button6_Click(object sender, EventArgs e)
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
    }
}
