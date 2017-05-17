using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn form = new LogIn();
            form.ShowDialog();
            this.Close();
        }

        private void прегледНаСлужителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeData form = new EmployeeData();
            form.ShowDialog();
        }

        private void прегледНаСписъкСПроектиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projectsss form = new Projectsss();
            form.ShowDialog();
        }

        private void списъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkTime form = new WorkTime();
            form.ShowDialog();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn form = new LogIn();
            form.Show();
        }

       
    }
}
