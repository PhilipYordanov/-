using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "Изход от приложението?";
            string caption = "Предупреждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Filip" && textBox2.Text == "123") || (textBox1.Text == "Radina" && textBox2.Text == "123") ||
                (textBox1.Text == "Plamen" && textBox2.Text == "123") || (textBox1.Text == "Silveto" && textBox2.Text == "123"))
            {
                this.Hide();
                MainForm sistema = new MainForm();
                sistema.ShowDialog();
                this.Close();
            }
            else
            {
                string message = "Грешно име или парола";
                string caption = "Предупреждение";
                DialogResult result;
                result = MessageBox.Show(message, caption);
            }
        }
    }
}
