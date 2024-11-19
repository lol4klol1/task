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
    public partial class authorization : Form
    {

        public authorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration newForm = new registration();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Task.DB.ConnectionString))
                {
                    connection.Open();
                    string sqlcommand = "SELECT * FROM [USER] WHERE [LOGIN] = @Login AND [Password]  = @Password;";
                    OleDbCommand dbCommand = new OleDbCommand(sqlcommand, connection);
                    dbCommand.Parameters.AddWithValue("@Login", LogintextBox.Text);
                    dbCommand.Parameters.AddWithValue("@Password", PasswordtextBox.Text);

                    using  (OleDbDataReader dataReader = dbCommand.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            MessageBox.Show($"Здраствуйте,{dataReader["firstName"]}");
                            this.Hide();
                            BDForm BDForm = new BDForm();
                            BDForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин/пароль!");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {44

        }
    }
}
