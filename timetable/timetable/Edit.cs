using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class Edit : Form
    {
        private int selectedIndex;

        public Edit(int selectedIndex)
        {
            this.selectedIndex = selectedIndex;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Сигурни ли сте,че искате да ЗАПАЗИТЕ промените ?";
            string caption = "Предупреждение";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.eMPLOYEESBindingSource.EndEdit();
                    employeesAdapterTable.Update(this.masterDataSet.EMPLOYEES);
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Нещо се обърка...");
                }
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Сигурни ли сте,че искате да ЗАПАЗИТЕ промените ?";
            string caption = "Предупреждение";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            eMPLOYEESBindingSource.Filter = "EMPLOYEE_ID=" + selectedIndex;
            this.employeesAdapterTable.Fill(this.masterDataSet.EMPLOYEES);
        }
    }
}
