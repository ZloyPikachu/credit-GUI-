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
    public partial class updateform : Form
    {
        public int contractID2, percentContract2, monthCount2;
        public double amount2;
        public string clSURNAME2, clNAME2, clLASTNAME2, dateStart2, clPASSPORT2, clTEL2, clADDRESS2;
        
        public updateform(int contractID1,
                            double amount1,
                            int percentContract1,
                            int monthCount1,
                            string dateStart1,
                            string clSURNAME1,
                            string clNAME1,
                            string clLASTNAME1, 
                            string clPASSPORT1,
                            string clTEL1,
                            string clADDRESS1)
        {
            InitializeComponent();

            this.contractID2 = contractID1;
            this.amount2           = amount1;
            this.percentContract2  = percentContract1 ;
            this.monthCount2       = monthCount1;
            this.dateStart2        = dateStart1;
            this.clSURNAME2        = clSURNAME1;
            this.clNAME2           = clNAME1;
            this.clLASTNAME2       = clLASTNAME1;
            this.clPASSPORT2 = clPASSPORT1;
            this.clTEL2 = clTEL1;
            this.clADDRESS2 = clADDRESS1;

            contractID.Text = contractID1.ToString();
            fullname.Text = clSURNAME1.ToString() +" " + clNAME1.ToString();

            amount.Text = amount1.ToString();
            percentContract.Text = percentContract1.ToString();
            monthCount.Text = monthCount1.ToString();
            dateStart.Text = dateStart1.ToString();
            clSURNAME.Text = clSURNAME1.ToString();
            clNAME.Text = clNAME1.ToString();
            clLASTNAME.Text = clLASTNAME1.ToString();
            clPASSPORT.Text = clPASSPORT1.ToString();
            clTEL.Text = clTEL1.ToString();
            clADDRESS.Text = clADDRESS1.ToString();

        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectString = "Data Source=localhost; Initial Catalog=creditsys; Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectString);

            try
            {
                connection.Open();
                string queryString = "UPDATE contract SET amount =" + amount.Text + ", percentContract =" + percentContract.Text + ", monthCount ="
                    + monthCount.Text +/* ", dateStart ='" + dateStart2 +*/ ", clNAME ='" + clNAME.Text + "' , clSURNAME ='" + clSURNAME.Text + "', clLASTNAME ='" + clLASTNAME.Text
                    + "',clPASSPORT ='" + clPASSPORT.Text + "', clTEL ='" + clTEL.Text + "', clADDRESS ='" + clADDRESS.Text + "' WHERE contractID =" + contractID.Text;
                //"exec updateContract " + contractID2 +","+amount2 +","+percentContract2 + ","+monthCount2 + ",'" +dateStart2 + "',"+clNAME2+"," + clLASTNAME2 + "," +clLASTNAME2 + "," +clPASSPORT2 + "," +clTEL2 + "," +clADDRESS2;
                //MessageBox.Show(queryString);
                SqlCommand query = new SqlCommand(queryString, connection);
                query.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Контракт изменен");
                Close();
                
            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());
                return;
            }
        }
    }
}
