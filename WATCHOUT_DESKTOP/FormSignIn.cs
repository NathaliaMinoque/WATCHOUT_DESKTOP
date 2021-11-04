using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WATCHOUT_DESKTOP
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=localhost;uid=root;pwd=;database=jam_tangan;";
        public static string ProfileName;
        public static string IDReseller;
        public static string IDResellerBaru;

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }
        public static string namares;

        private void labelSignup_Click(object sender, EventArgs e)
        {
            bunifuPagesSign.SelectTab(tabPageSignUp);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            bunifuPagesSign.SelectTab(tabPageSignUp);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bunifuPagesSign.SelectTab(tabPageLogIn);
        }

        private void labelSULogIn_Click(object sender, EventArgs e)
        {
            bunifuPagesSign.SelectTab(tabPageLogIn);
        }

        //ZEFA
        private void labelSUSignUp_Click(object sender, EventArgs e)
        {
             try
            {
                //AUTOGENERATE ID MEMBERSHIP
                string IDMembershipBaru = "C/";
                IDMembershipBaru += tboxSUFirstName.Text.Substring(0, 1).ToUpper();
                IDMembershipBaru += tboxSULastName.Text.Substring(0, 1).ToUpper();
                IDMembershipBaru += "/21";
                sqlQuery = "SELECT * FROM membership";
                DataTable dtMembershipBaru = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtMembershipBaru);
                int jumlahMembership = dtMembershipBaru.Rows.Count + 1;
                if (jumlahMembership < 10)
                {
                    IDMembershipBaru += "0000";
                    IDMembershipBaru += jumlahMembership.ToString();
                }
                else if (jumlahMembership < 100)
                {
                    IDMembershipBaru += "000";
                    IDMembershipBaru += jumlahMembership.ToString();
                }
                else if (jumlahMembership < 1000)
                {
                    IDMembershipBaru += "00";
                    IDMembershipBaru += jumlahMembership.ToString();
                }
                else if (jumlahMembership < 10000)
                {
                    IDMembershipBaru += "0";
                    IDMembershipBaru += jumlahMembership.ToString();
                }
                else
                {
                    IDMembershipBaru += jumlahMembership.ToString();
                }

                //AUTOGENERATE ID RESELLER
                IDResellerBaru = "RES/";
                IDResellerBaru += tboxSUFirstName.Text.Substring(0, 1).ToUpper();
                IDResellerBaru += tboxSULastName.Text.Substring(0, 1).ToUpper();
                IDResellerBaru += "/21";


                sqlQuery = "SELECT * FROM reseller";
                DataTable dtResellerBaru = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtResellerBaru);
                int jumlahReseller = dtResellerBaru.Rows.Count + 1;
                if (jumlahReseller < 10)
                {
                    IDResellerBaru += "0000";
                    IDResellerBaru += jumlahReseller.ToString();
                }
                else if (jumlahReseller < 100)
                {
                    IDResellerBaru += "000";
                    IDResellerBaru += jumlahReseller.ToString();
                }
                else if (jumlahReseller < 1000)
                {
                    IDResellerBaru += "00";
                    IDResellerBaru += jumlahReseller.ToString();
                }
                else if (jumlahReseller < 10000)
                {
                    IDResellerBaru += "0";
                    IDResellerBaru += jumlahReseller.ToString();
                }
                else
                {
                    IDResellerBaru += jumlahReseller.ToString();
                }


                //AUTOGENERATE CART_ID
                string IDCart = "C/";
                IDCart += IDResellerBaru.ToString();

                if (tboxSUFirstName.Text == "" || tboxSULastName.Text == "" || tboxSUEmail.Text == "" || tboxSUPhone.Text == "" || tboxSUAddress.Text == "" || tboxSUPassword.Text == "")
                {
                    MessageBox.Show("Please fill in all the required fields.");
                }
                else if (tboxSUFirstName.Text != "" && tboxSULastName.Text != "" && tboxSUEmail.Text != "" && tboxSUPhone.Text != "" && tboxSUAddress.Text != "" && tboxSUPassword.Text != "")
                {
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into membership values ('" + IDMembershipBaru.ToString() + "', '2.5', 'Classic', '0')";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    sqlQuery = "insert into reseller values ('" + IDResellerBaru.ToString() + "', '" + IDMembershipBaru.ToString() + "', concat('" + tboxSUFirstName.Text + "', ' ', '" + tboxSULastName.Text + "'), '" + tboxSUAddress.Text + "', '" + tboxSUEmail.Text + "', '" + tboxSUPhone.Text + "', '" + tboxSUPassword.Text + "', null, '0')";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    sqlQuery = "insert into transaksi_pembelian(BELI_ID, R_ID, BELI_DISKON, BELI_ACC, BELI_DELETE) values('"+IDCart.ToString()+"', '"+IDResellerBaru.ToString()+"', '2.50', '2', '0')";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    MessageBox.Show("Congratulations, your account has been successfully created! Please Login.");
                    bunifuPagesSign.SelectTab(tabPageLogIn);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new MySqlConnection(connectString);
                DataTable dtEmail = new DataTable();
                sqlQuery = "select R_EMAIL as `Email`, R_PASSWORD as `Password`, substring_index(R_NAMA, ' ', 1) as `First Name`, R_ID as `ID Reseller`, r_nama from reseller where R_EMAIL = '" + tboxEmail.Text.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtEmail);

                if (dtEmail.Rows[0][0].ToString() == tboxEmail.Text.ToString() && dtEmail.Rows[0][1].ToString() == tboxPassword.Text.ToString())
                {
                    IDReseller = dtEmail.Rows[0][3].ToString();
                    ProfileName = dtEmail.Rows[0][2].ToString();
                    namares = dtEmail.Rows[0]["r_nama"].ToString();
                    FormHome formHome = new FormHome();
                    formHome.Show();
                    this.Hide();
                }
                else if (dtEmail.Rows[0][0].ToString() != tboxEmail.Text.ToString() || dtEmail.Rows[0][1].ToString() != tboxPassword.Text.ToString())
                {
                    MessageBox.Show("Incorrect email address or password, please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tboxSUPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ini code biar yg masuk angka doang
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabPageSignUp_Click(object sender, EventArgs e)
        {

        }

        private void tabPageLogIn_Click(object sender, EventArgs e)
        {

        }
    }
}
