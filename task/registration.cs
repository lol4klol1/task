using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Task.DB.ConnectionString))
                {
                    connection.Open();

                    string sqlExpression = "INSERT INTO [User] ([IdUserRole], [FirstName], [Login], [Password]) " +
                        "VALUES (@Role, @Name, @Login, @Password);";
                    OleDbCommand sqlCommand = new OleDbCommand(sqlExpression, connection);
                    sqlCommand.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Login", LoginTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                    int number = sqlCommand.ExecuteNonQuery();
                    if (number >= 1)
                    {
                        MessageBox.Show("Успешная регистрация!");

                        this.Hide();
                        BDForm BDForm = new BDForm();
                        BDForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка регистрации!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Зарегистрироваться_Click(object sender, EventArgs e)
        {

        }
    }
}
