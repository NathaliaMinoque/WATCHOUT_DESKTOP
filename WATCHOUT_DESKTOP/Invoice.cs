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
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=localhost;uid=root;pwd=;database=jam_tangan;";

        private void buttonBackInv_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "DELETE FROM report_detail";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
