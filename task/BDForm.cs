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
    public partial class BDForm : Form
    {
        public BDForm()
        {
            InitializeComponent();



            try

            {//[User].[iduser]
                string Db = "SELECT [User].[FirstName] as [Имя],[Tasks].[Tasker] as [Задачи],[Tasks].[Idtask] as [IdЗадачи],[Static].[static] as [Статус работы] " + "FROM ([User] INNER JOIN [Tasks] ON [User].[iduser] = [Tasks].[iduser]) INNER JOIN [Static] ON [Tasks].[idstatic] = [Static].[idstatic]";

                using (OleDbConnection connection = new OleDbConnection(Task.DB.ConnectionString))
                {
                    connection.Open();

                    OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter(Db, Task.DB.ConnectionString);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void zareg_Click(object sender, EventArgs e)
        {
            {
                registration newForm = new registration();
                newForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorization newForm = new authorization();
            newForm.ShowDialog();
        }

        private void BDForm_Load(object sender, EventArgs e)
        {

        }
    }
}
