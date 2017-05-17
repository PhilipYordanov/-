using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class EditProject : Form
    {
        private int selectedIndex;

        public EditProject(int selectedIndex)
        {
            this.selectedIndex = selectedIndex;
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
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
                    this.pROJECTBindingSource.EndEdit();
                    pROJECTTableAdapter.Update(this.masterDataSet.PROJECT);
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
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

        private void EditProject_Load(object sender, EventArgs e)
        {
            pROJECTBindingSource.Filter = "PROJECT_ID=" + selectedIndex;
            this.pROJECTTableAdapter.Fill(this.masterDataSet.PROJECT);
        }
    }
}
