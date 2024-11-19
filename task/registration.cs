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

        private void reg_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(Task.DB.ConnectionString))
                {
                    connection.Open();



                    string sqlExpression = "INSERT INTO [Tasks] ([@Idtask],[Tasker],[idstatic],[iduser]) " +
                        "VALUES (@Tasker,@iduser,@idstatic,@idtask);";
                    OleDbCommand sqlCommand = new OleDbCommand(sqlExpression, connection);
                    sqlCommand.Parameters.AddWithValue("@iduser ", int.Parse(FirstNameTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("@Tasker", tasktextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@idstatic", int.Parse(idstatictextBox.Text));
                    sqlCommand.Parameters.AddWithValue("@Idtask", NameTextBox.Text);
                    
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

        private void nazad_Click(object sender, EventArgs e)
        {
            BDForm newForm = new BDForm();
            newForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idstatictextBox_TextChanged(object sender, EventArgs e)
        { 

        }
    }
}
