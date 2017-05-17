using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace timetable
{
    public partial class CreateNewEmployee : Form
    {
        public CreateNewEmployee()
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
            long number;

            if (textBox1.Text.Length == 10)
            {
                bool result = Int64.TryParse(textBox1.Text, out number);
                if (result == true && number >= 0)
                {
                    var epmEGN = number;
                    number = epmEGN;
                }
                else
                {
                    InvalidEGN();
                    return;
                }
            }
            else
            {
                InvalidEGN();
                return;
            }

            var empName = textBox2.Text;
            var empSurname = textBox3.Text;
            var empLastname = textBox4.Text;
            var empPos = comboBox1.Text;
            var asd = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");

            SqlConnection conn = new SqlConnection(ConfigurationManager
                .ConnectionStrings["timetable.Properties.Settings.ConnectString"]
                .ConnectionString);

            string insertSql = "INSERT INTO " +
                "EMPLOYEES (EMPLOYEE_EGN,EMPLOYEE_NAME,EMPLOYEE_SURNAME,EMPLOYEE_LASTNAME,EMPLOYEE_POSITION,EMPLOYEE_HIREDATE)" +
                "VALUES (@epmEGN, @empName, @empSurname, @empLastname, @empPos,@empHireDate)";
            using (conn)
            {
                using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("epmEGN", number));
                        cmd.Parameters.Add(new SqlParameter("empName", empName));
                        cmd.Parameters.Add(new SqlParameter("empSurname", empSurname));
                        cmd.Parameters.Add(new SqlParameter("empLastname", empLastname));
                        cmd.Parameters.Add(new SqlParameter("empPos", empPos));
                        cmd.Parameters.Add(new SqlParameter("empHireDate", asd));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        var fullName = empName + " " + empSurname;
                        var addedEmp = fullName + " was successfully added";
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

        private static void InvalidEGN()
        {
            MessageBox.Show("Невалиден формат на ЕГН",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                      );
        }
    }
}
