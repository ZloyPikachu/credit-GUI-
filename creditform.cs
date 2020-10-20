using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace v10
{
    public partial class creditform : Form
    {
        public creditform()
        {
            InitializeComponent();
            LoadData();
        }

        int contractID1, percentContract1, monthCount1;
        double amount1;
        string clSURNAME1, clNAME1, clLASTNAME1, dateStart1, clPASSPORT1, clTEL1, clADDRESS1;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.contractID1 = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.clSURNAME1 = dataGridView1.SelectedRows[0].Cells["clSURNAME"].Value.ToString();
            this.clNAME1 = dataGridView1.SelectedRows[0].Cells["clNAME"].Value.ToString();

            string messageText = "Вы хотите удалить пользователя: " + this.clSURNAME1 + " " + this.clNAME1;

            DialogResult result = MessageBox.Show(messageText, "Удаление пользователя", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connectString = "Data Source=localhost; Initial Catalog=creditsys; Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectString);

                try
                {
                    connection.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                    return;
                }

                string queryString = "delete from contract where contractID =" + this.contractID1;
                SqlCommand query = new SqlCommand(queryString, connection);

                try
                {
                    query.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ошибка удаления пользователя!\n" + error);
                    return;
                }

                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Refresh();
                this.LoadData();
            }
        }
        /*refresh*/
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void repay_Click(object sender, EventArgs e)
        {
            this.contractID1 = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            
            string connectString = "Data Source=localhost; Initial Catalog=creditsys; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectString);

            try
            {
                connection.Open();
                string queryString = "exec repayments "+ contractID1;
                SqlCommand query = new SqlCommand(queryString, connection);
                //MessageBox.Show(queryString);
                MessageBox.Show("Контракт №" + contractID1 + " вычислен!");
                query.ExecuteNonQuery();
                connection.Close();


            }
            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
                return;
            }

        }

        /***/


        /*-load data-*/
        public void LoadData()
        {
            string connectString = "Data Source=localhost; Initial Catalog=creditsys; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectString);

            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }

            string queryString = "select * from contract";
            SqlCommand query = new SqlCommand(queryString, connection);

            SqlDataReader reader = query.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[11]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
            }

            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        /*--*/








        /*showdialog forms*/
        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paymentform f = new paymentform();
            f.ShowDialog();
        }

        /*insert*/
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertform f = new insertform();
            f.ShowDialog();
        }
        private void insert_Click(object sender, EventArgs e)
        {
            insertform f = new insertform();
            f.ShowDialog();
        }
        /**/
        /*update*/
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.contractID1 = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.amount1 = double.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            this.percentContract1 = int.Parse(dataGridView1.SelectedRows[0].Cells["percentContract"].Value.ToString());
            this.monthCount1 = int.Parse(dataGridView1.SelectedRows[0].Cells["monthCount"].Value.ToString());
            this.dateStart1 = dataGridView1.SelectedRows[0].Cells["dateStart"].Value.ToString();
            this.clSURNAME1 = dataGridView1.SelectedRows[0].Cells["clSURNAME"].Value.ToString();
            this.clNAME1 = dataGridView1.SelectedRows[0].Cells["clNAME"].Value.ToString();
            this.clLASTNAME1 = dataGridView1.SelectedRows[0].Cells["clLASTNAME"].Value.ToString();
            this.clPASSPORT1 = dataGridView1.SelectedRows[0].Cells["clPASSPORT"].Value.ToString();
            this.clTEL1 = dataGridView1.SelectedRows[0].Cells["clTEL"].Value.ToString();
            this.clADDRESS1 = dataGridView1.SelectedRows[0].Cells["clADDRESS"].Value.ToString();

            Console.WriteLine(contractID1);
            /**/
            updateform f = new updateform(this.contractID1, this.amount1, this.percentContract1, this.monthCount1, this.dateStart1, this.clSURNAME1,
                                            this.clNAME1, this.clLASTNAME1, this.clPASSPORT1, this.clTEL1, this.clADDRESS1);
            f.ShowDialog();
        }
        private void update_Click(object sender, EventArgs e)
        {
            this.contractID1        = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.amount1            = double.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            this.percentContract1   = int.Parse(dataGridView1.SelectedRows[0].Cells["percentContract"].Value.ToString());
            this.monthCount1        = int.Parse(dataGridView1.SelectedRows[0].Cells["monthCount"].Value.ToString());
            this.dateStart1         = dataGridView1.SelectedRows[0].Cells["dateStart"].Value.ToString();
            this.clSURNAME1         = dataGridView1.SelectedRows[0].Cells["clSURNAME"].Value.ToString();
            this.clNAME1            = dataGridView1.SelectedRows[0].Cells["clNAME"].Value.ToString();
            this.clLASTNAME1        = dataGridView1.SelectedRows[0].Cells["clLASTNAME"].Value.ToString();
            this.clPASSPORT1        = dataGridView1.SelectedRows[0].Cells["clPASSPORT"].Value.ToString();
            this.clTEL1             = dataGridView1.SelectedRows[0].Cells["clTEL"].Value.ToString();
            this.clADDRESS1         = dataGridView1.SelectedRows[0].Cells["clADDRESS"].Value.ToString();
            
            Console.WriteLine(contractID1);     
            /**/
            updateform f = new updateform(this.contractID1, this.amount1, this.percentContract1 , this.monthCount1 , this.dateStart1 , this.clSURNAME1 ,
                                            this.clNAME1, this.clLASTNAME1, this.clPASSPORT1,  this.clTEL1,     this.clADDRESS1);
            f.ShowDialog();
        }
        /**/
        /*delete*/
        private void delete_Click(object sender, EventArgs e)
        {
            this.contractID1 = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.clSURNAME1 = dataGridView1.SelectedRows[0].Cells["clSURNAME"].Value.ToString();
            this.clNAME1 = dataGridView1.SelectedRows[0].Cells["clNAME"].Value.ToString();

            string messageText = "Вы хотите удалить пользователя: " + this.clSURNAME1 +" " + this.clNAME1;

            DialogResult result = MessageBox.Show(messageText, "Удаление пользователя", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connectString = "Data Source=localhost; Initial Catalog=creditsys; Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectString);

                try
                {
                    connection.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                    return;
                }

                string queryString = "delete from contract where contractID =" + this.contractID1;
                SqlCommand query = new SqlCommand(queryString, connection);

                try
                {
                   query.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ошибка удаления пользователя!\n" + error);
                    return;
                }

                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Refresh();
                this.LoadData();
            }
        }


        /**/
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
