using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace timetable
{
    public partial class CreateProjectsss : Form
    {
        public CreateProjectsss()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Сигурни ли сте,че искате да затворите формата ?";
            string caption = "Предупреждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var statusFinal = "";
            int number;

            if (comboBox1.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show(@"Полето ""Статус"" е задължително");
                return;
            }

            var projectName = textBox2.Text;
            var projectBegin = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"); 
            var projectEnd = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            var projectDescription = richTextBox1.Text;

            var projectStatus = comboBox1.SelectedItem.ToString();

            bool result = Int32.TryParse(textBox6.Text, out number);
            if (result == true && number >= 0)
            {
                var projectMaxHrs = number;
                number = projectMaxHrs;
            }
            else
            {
                MessageBox.Show("Въведи реални часове за проектa!");
                return;
            }

            if (DateTime.Parse(projectBegin) > DateTime.Parse(projectEnd))
            {
                MessageBox.Show("Няма как да почва след като е свършил");
                return;
            }

            statusFinal = ProjectStatus(projectStatus);

            SqlConnection conn = new SqlConnection(ConfigurationManager
                .ConnectionStrings["timetable.Properties.Settings.ConnectString"]
                .ConnectionString);

            string insertSql = "INSERT INTO " +
                "PROJECT (PROJECT_NAME,PROJECT_BEGIN,PROJECT_END,PROJECT_DESCRIPTION,PROJECT_STATUS,PROJECT_MAXHOURS)" +
                "VALUES (@projectName, @projectBegin, @projectEnd, @projectDescription, @projectStatus,@projectMaxHrs)";
            using (conn)
            {
                using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("projectName", projectName));
                        cmd.Parameters.Add(new SqlParameter("projectBegin", projectBegin));
                        cmd.Parameters.Add(new SqlParameter("projectEnd", projectEnd));
                        cmd.Parameters.Add(new SqlParameter("projectDescription", projectDescription));
                        cmd.Parameters.Add(new SqlParameter("projectStatus", statusFinal));
                        cmd.Parameters.Add(new SqlParameter("projectMaxHrs", number));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        var addedEmp = projectName + " was successfully added";
                        MessageBox.Show(addedEmp,
                        "Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                       );
                        this.Close();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private static string ProjectStatus(string projectStatus)
        {
            string statusFinal;
            if (projectStatus == "Отворен")
            {
                statusFinal = "o";
            }
            else
            {
                statusFinal = "c";
            }
            return statusFinal;
        }
    }
}
