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
    public partial class paymentform : Form
    {
        public paymentform()
        {
            InitializeComponent();
            LoadData();
        }
        public static string dbConnect = "Data Source=localhost; Initial Catalog=creditsys; Integrated Security=true; ";
        public static SqlConnection connection = new SqlConnection(dbConnect);

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

            string queryString = "select * from repayment";
            SqlCommand query = new SqlCommand(queryString, connection);

            SqlDataReader reader = query.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }

            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void payments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "creditsysDataSet.repayment". При необходимости она может быть перемещена или удалена.
            this.repaymentTableAdapter.Fill(this.creditsysDataSet.repayment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string connectString = "Data Source=localhost; Initial Catalog=creditsys; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectString);

            try
            {
                connection.Open();
            }
            catch (Exception j)
            {
                MessageBox.Show(j.ToString());
                return;
            }

            string queryString = "select * from repayment where contractID=" + id.Text;
            SqlCommand query = new SqlCommand(queryString, connection);

            SqlDataReader reader = query.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }

            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }
    }
}
