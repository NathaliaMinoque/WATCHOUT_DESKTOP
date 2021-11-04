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
    public partial class FormInv : Form
    {
        public FormInv()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=localhost;uid=root;pwd=;database=jam_tangan;";

        private void buttonBackInvoicee_Click(object sender, EventArgs e)
        {
            try
            {
                FormHome formHome = new FormHome();
                formHome.Show();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Invoice cobaReport = new Invoice();
            crystalReportViewer1.RefreshReport();
        }
    }
}
