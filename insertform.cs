using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v10
{
    public partial class insertform : Form
    {
        public insertform()
        {
            InitializeComponent();
        }
        public static string dbConnect = "Data Source=localhost; Initial Catalog=creditsys; Integrated Security=true; ";
        public static SqlConnection connection = new SqlConnection(dbConnect);

        private void insertform_Load(object sender, EventArgs e)
        {
            //
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                String Command = "INSERT INTO contract VALUES(" + amount.Text + "," + percentContract.Text + "," + monthCount.Text + ",'" + dateStart.Text + "','"
                                    + clNAME.Text + "','"  + clSURNAME.Text + "','" + clLASTNAME.Text + "','" +  clPASSPORT.Text + "','" + clTEL.Text + "','" + clADDRESS.Text + "')";  
                    
                SqlCommand query = new SqlCommand(Command, connection);
                query.ExecuteNonQuery();

                connection.Close();
                //MessageBox.Show(Command);
                MessageBox.Show("Контракт добавлен");
                Close();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return;
            }

            connection.Close();
        }
    }
}
