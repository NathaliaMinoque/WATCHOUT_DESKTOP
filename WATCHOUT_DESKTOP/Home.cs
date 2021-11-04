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
using System.IO;


namespace WATCHOUT_DESKTOP
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=localhost;uid=root;pwd=;database=jam_tangan;";
        public Panel[,] panel = new Panel[9, 9];
        public Label[,] labelNamaProduk = new Label[9, 9];
        public Label[,] labelWarnaProduk = new Label[9, 9];
        public Label[,] labelHarga = new Label[9, 9];
        public PictureBox[,] pbox = new PictureBox[9, 9];
        public static string[] SKU = new string[81];
        public static string SKUAktif;
        string IDBeli;
        public static string back;
        public static int stock;
        public static string IDCart;
        public static double totalharga;
        public static double totalfinal;
        public static string totalfinalstring;
        public static int price;
        public static int sama;
        public static string totalqty;
        public static string tanggalbeli;
        public static string warna;
        public static string size;
        public static string qty;
        public static string item;
        
        //MINOQ
        private void panel_click(object sender, EventArgs e)
        {
            try
            {
                bunifuPageHome.SelectTab(tabPageDetail);
                var panelss = sender as Panel;
                SKUAktif = Convert.ToString(panelss.Tag);
                fill_detail();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pbox_click(object sender, EventArgs e)
        {
            try
            {
                bunifuPageHome.SelectTab(tabPageDetail);
                var pboxx = sender as PictureBox;
                SKUAktif = Convert.ToString(pboxx.Tag);
                fill_detail();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void nama_click(object sender, EventArgs e)
        {
            try
            {
                bunifuPageHome.SelectTab(tabPageDetail);
                var namaa = sender as Label;
                SKUAktif = Convert.ToString(namaa.Tag);
                fill_detail();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void warna_click(object sender, EventArgs e)
        {
            try
            {
                bunifuPageHome.SelectTab(tabPageDetail);
                var warnaa = sender as Label;
                SKUAktif = Convert.ToString(warnaa.Tag);
                fill_detail();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void harga_click(object sender, EventArgs e)
        {
            try
            {
                bunifuPageHome.SelectTab(tabPageDetail);
                var hargaa = sender as Label;
                SKUAktif = Convert.ToString(hargaa.Tag);
                fill_detail();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void fill_detail()
        {
            numQty.Value = 1;
            //SKUAKtif = SKU yang lagi di klik
            sqlConnect = new MySqlConnection(connectString);
            DataTable dtDetail = new DataTable();
            sqlQuery = "select J_SKU, J_MERK as `Nama`, J_STOK as `Stock`, J_WARNA as `Warna`, J_HARGA as `Harga`, J_DESKRIPSI as `Desc`, J_UKURAN as `Ukuran` from jam_tangan where J_SKU='" + SKUAktif + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetail);

            labelStock.Text = dtDetail.Rows[0]["Stock"].ToString();
            stock = Convert.ToInt32(dtDetail.Rows[0]["Stock"]);
            price = Convert.ToInt32(dtDetail.Rows[0]["Harga"]);
            labelDescription.Text = dtDetail.Rows[0]["Desc"].ToString();
            labelPrice.Text = "$" + dtDetail.Rows[0]["Harga"].ToString();
            labelProductName.Text = dtDetail.Rows[0]["Nama"].ToString();
            labelSize.Text = dtDetail.Rows[0]["Ukuran"].ToString();

            size = dtDetail.Rows[0]["Ukuran"].ToString();
            warna = dtDetail.Rows[0]["Warna"].ToString();
            item = dtDetail.Rows[0]["Nama"].ToString();

            if (dtDetail.Rows[0]["Warna"].ToString() == "Black")
            {
                buttonColor.IdleFillColor = Color.Black;
            }
            else if (dtDetail.Rows[0]["Warna"].ToString() == "Pink")
            {
                buttonColor.IdleFillColor = Color.Pink;
            }
            else if (dtDetail.Rows[0]["Warna"].ToString() == "Brown")
            {
                buttonColor.IdleFillColor = Color.Brown;
            }
            else if (dtDetail.Rows[0]["Warna"].ToString() == "Gold")
            {
                buttonColor.IdleFillColor = Color.Gold;
            }
            else if (dtDetail.Rows[0]["Warna"].ToString() == "Blue")
            {
                buttonColor.IdleFillColor = Color.Blue;
            }
            else if (dtDetail.Rows[0]["Warna"].ToString() == "White")
            {
                buttonColor.IdleFillColor = Color.White;
            }
            else if (dtDetail.Rows[0]["Warna"].ToString() == "Silver")
            {
                buttonColor.IdleFillColor = Color.Silver;
            }
            else if (dtDetail.Rows[0]["Warna"].ToString() == "Green")
            {
                buttonColor.IdleFillColor = Color.Green;
            }
            else if (dtDetail.Rows[0]["Warna"].ToString() == "Red")
            {
                buttonColor.IdleFillColor = Color.Red;
            }

            //NGISI GAMBAR WOY             
            sqlConnect = new MySqlConnection(connectString);
            sqlQuery = "select J_FOTO from jam_tangan where J_SKU='" + SKUAktif + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtGambar = new DataTable();
            sqlAdapter.Fill(dtGambar);
            byte[] img = (byte[])dtGambar.Rows[0][0];

            MemoryStream memoryStream = new MemoryStream(img);
            pictureBoxDetail.Image = Image.FromStream(memoryStream);
            sqlAdapter.Dispose();
        }

        //ZEFANYA
        private void pictBoxProfile_Click(object sender, EventArgs e)
        {
            try
            {
                ShowProfile();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //ZEFANYA
        private void ShowProfile()
        {
            try
            {
                bunifuPageHome.SelectTab(tabPageProfile);

                sqlConnect = new MySqlConnection(connectString);
                DataTable dtProfile = new DataTable();
                sqlQuery = "select R_ID as `ID Reseller`, R_EMAIL as `Email`, R_HP as `No HP`, R_ALAMAT as `Alamat`, R_PASSWORD as `Password`, R_NAMA as `Nama` from reseller where R_ID = '" + FormSignIn.IDReseller + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtProfile);

                
                tboxIDReseller.Text = dtProfile.Rows[0][0].ToString();
                tboxEmail.Text = dtProfile.Rows[0][1].ToString();
                tboxNoHP.Text = dtProfile.Rows[0][2].ToString();
                tboxAlamat.Text = dtProfile.Rows[0][3].ToString();
                tboxPassword.Text = dtProfile.Rows[0][4].ToString();
                labelNamadiProfile.Text = dtProfile.Rows[0][5].ToString();
                

                tboxEditIDReseller.Text = dtProfile.Rows[0][0].ToString();
                tboxEditEmail.Text = dtProfile.Rows[0][1].ToString();
                tboxEditNoHP.Text = dtProfile.Rows[0][2].ToString();
                tboxEditAlamat.Text = dtProfile.Rows[0][3].ToString();
                tboxEditPassword.Text = dtProfile.Rows[0][4].ToString();
                labelEditNama.Text = dtProfile.Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelEditProfile_Click(object sender, EventArgs e)
        {
            try
            {
                bunifuPageHome.SelectTab(tabPageEditProfile);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void labelSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new MySqlConnection(connectString);
                DataTable dtEditProfile = new DataTable();
                sqlQuery = "select R_ID as `ID Reseller`, R_EMAIL as `Email`, R_HP as `No HP`, R_ALAMAT as `Alamat`, R_PASSWORD as `Password`, R_NAMA as `Nama` from reseller where R_ID = '" + FormSignIn.IDReseller + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtEditProfile);

                if (tboxEditIDReseller.Text == dtEditProfile.Rows[0][0].ToString() && tboxEditEmail.Text == dtEditProfile.Rows[0][1].ToString() && tboxEditNoHP.Text == dtEditProfile.Rows[0][2].ToString() && tboxEditAlamat.Text == dtEditProfile.Rows[0][3].ToString() && tboxEditPassword.Text == dtEditProfile.Rows[0][4].ToString())
                {
                    DialogResult dialogResult = MessageBox.Show("No data has been changed. Do you still want to edit your profile?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do nothing
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        bunifuPageHome.SelectTab(tabPageProfile);
                    }
                }
                else if (tboxEditIDReseller.Text != dtEditProfile.Rows[0][0].ToString() || tboxEditEmail.Text != dtEditProfile.Rows[0][1].ToString() || tboxEditNoHP.Text != dtEditProfile.Rows[0][2].ToString() || tboxEditAlamat.Text != dtEditProfile.Rows[0][3].ToString() || tboxEditPassword.Text != dtEditProfile.Rows[0][4].ToString())
                {
                    DialogResult dialogResult2 = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        sqlQuery = "update reseller set R_EMAIL = '" + tboxEditEmail.Text + "', R_HP = '" + tboxEditNoHP.Text + "', R_ALAMAT = '" + tboxEditAlamat.Text + "', R_PASSWORD = '" + tboxEditPassword.Text + "' where R_ID = '" + tboxEditIDReseller.Text + "'";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlConnect.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnect.Close();
                        bunifuPageHome.SelectTab(tabPageProfile);

                        DataTable dtProfile = new DataTable();
                        sqlQuery = "select R_ID as `ID Reseller`, R_EMAIL as `Email`, R_HP as `No HP`, R_ALAMAT as `Alamat`, R_PASSWORD as `Password`, R_NAMA as `Nama` from reseller where R_ID = '" + FormSignIn.IDReseller + "'";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(dtProfile);

                        tboxIDReseller.Text = dtProfile.Rows[0][0].ToString();
                        tboxEmail.Text = dtProfile.Rows[0][1].ToString();
                        tboxNoHP.Text = dtProfile.Rows[0][2].ToString();
                        tboxAlamat.Text = dtProfile.Rows[0][3].ToString();
                        tboxPassword.Text = dtProfile.Rows[0][4].ToString();
                        labelNamadiProfile.Text = dtProfile.Rows[0][5].ToString();
                    }
                    else if (dialogResult2 == DialogResult.No)
                    {
                        //do nothing
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonKids_Click(object sender, EventArgs e)
        {
            labelProfileName4.Text = FormSignIn.ProfileName;
            bunifuPageHome.SelectTab(tabPageKids);
            int nomork = 1;
            back = "Kids";

            try
            {
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        sqlConnect = new MySqlConnection(connectString);
                        DataTable dtKids = new DataTable();
                        sqlQuery = "select J_SKU, J_MERK as `Nama`, J_WARNA as `Warna`, J_HARGA as `Harga` from jam_tangan where J_SKU like 'K%' ";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(dtKids);
                        int i = nomork - 1;

                        panel[x, y] = new Panel();
                        panel[x, y].Name = nomork.ToString();
                        panel[x, y].Location = new Point((x + 0) * 193, (y + 0) * 220);
                        panel[x, y].Visible = true;
                        panel[x, y].Size = new Size(170, 200);
                        panel[x, y].BackColor = Color.AliceBlue;

                        for (i = nomork - 1; i <= nomork - 1; i++)
                        {
                            SKU[nomork] = dtKids.Rows[i][0].ToString();

                            labelNamaProduk[x, y] = new Label();
                            labelNamaProduk[x, y].Text = "" + dtKids.Rows[i]["Nama"].ToString() + "";
                            labelNamaProduk[x, y].Size = new Size(170, 20);
                            labelNamaProduk[x, y].Location = new Point((((x + 0) * 193)), ((y + 0) * 220) + 130);
                            labelNamaProduk[x, y].BackColor = Color.AliceBlue;
                            labelNamaProduk[x, y].TextAlign = ContentAlignment.MiddleCenter;

                            labelWarnaProduk[x, y] = new Label();
                            labelWarnaProduk[x, y].Text = "" + dtKids.Rows[i]["Warna"].ToString() + "";
                            labelWarnaProduk[x, y].Size = new Size(170, 20);
                            labelWarnaProduk[x, y].Location = new Point((((x + 0) * 193)), ((y + 0) * 220) + 150);
                            labelWarnaProduk[x, y].BackColor = Color.AliceBlue;
                            labelWarnaProduk[x, y].TextAlign = ContentAlignment.MiddleCenter;

                            labelHarga[x, y] = new Label();
                            labelHarga[x, y].Text = "$" + "" + dtKids.Rows[i]["Harga"] + "";
                            labelHarga[x, y].Size = new Size(170, 30);
                            labelHarga[x, y].Location = new Point((((x + 0) * 193)), ((y + 0) * 220) + 170);
                            labelHarga[x, y].BackColor = Color.AliceBlue;
                            labelHarga[x, y].TextAlign = ContentAlignment.MiddleCenter;

                            pbox[x, y] = new PictureBox();
                            pbox[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pbox[x, y].Size = new Size(95, 115);
                            pbox[x, y].Location = new Point((((x + 0) * 193) + 40), ((y + 0) * 220) + 10);
                            pbox[x, y].BackColor = Color.AliceBlue;

                            pbox[x, y].Tag = SKU[nomork];
                            panel[x, y].Tag = SKU[nomork];
                            labelNamaProduk[x, y].Tag = SKU[nomork];
                            labelWarnaProduk[x, y].Tag = SKU[nomork];
                            labelHarga[x, y].Tag = SKU[nomork];

                            //NGISI GAMBAR WOY             
                            sqlConnect = new MySqlConnection(connectString);
                            sqlQuery = "select J_FOTO from jam_tangan where J_SKU='" + SKU[nomork] + "'";
                            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                            sqlAdapter = new MySqlDataAdapter(sqlCommand);
                            DataTable dtGambar = new DataTable();
                            sqlAdapter.Fill(dtGambar);
                            byte[] img = (byte[])dtGambar.Rows[0][0];

                            MemoryStream memoryStream = new MemoryStream(img);
                            pbox[x, y].Image = Image.FromStream(memoryStream);
                            sqlAdapter.Dispose();
                        }

                        bunifuPanelProdukKids.Controls.Add(pbox[x, y]);
                        bunifuPanelProdukKids.Controls.Add(labelHarga[x, y]);
                        bunifuPanelProdukKids.Controls.Add(labelWarnaProduk[x, y]);
                        bunifuPanelProdukKids.Controls.Add(labelNamaProduk[x, y]);
                        bunifuPanelProdukKids.Controls.Add(panel[x, y]);
                        nomork++;

                        pbox[x, y].Click += new EventHandler(pbox_click);
                        panel[x, y].Click += new EventHandler(panel_click);
                        labelHarga[x, y].Click += new EventHandler(harga_click);
                        labelWarnaProduk[x, y].Click += new EventHandler(warna_click);
                        labelNamaProduk[x, y].Click += new EventHandler(nama_click);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ButtonTop_Click(object sender, EventArgs e)
        {
            try
            {
                back = "Top";
                labelProfileName2.Text = FormSignIn.ProfileName;
                bunifuPageHome.SelectTab(tabPageTop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonWomen_Click(object sender, EventArgs e)
        {
            try
            {
                labelProfileName3.Text = FormSignIn.ProfileName;
                bunifuPageHome.SelectTab(tabPageWomen);
                int nomorw = 1;
                back = "Women";

                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        sqlConnect = new MySqlConnection(connectString);
                        DataTable dtWomen = new DataTable();
                        sqlQuery = "select J_SKU, J_MERK as `Nama`, J_WARNA as `Warna`, J_HARGA as `Harga` from jam_tangan where J_SKU like 'W%' ";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(dtWomen);
                        int i = nomorw - 1;

                        panel[x, y] = new Panel();
                        panel[x, y].Name = nomorw.ToString();
                        panel[x, y].Location = new Point((x + 0) * 193, (y + 0) * 220);
                        panel[x, y].Visible = true;
                        panel[x, y].Size = new Size(170, 200);
                        panel[x, y].BackColor = Color.LavenderBlush;

                        for (i = nomorw - 1; i <= nomorw - 1; i++)
                        {

                            SKU[nomorw] = dtWomen.Rows[i][0].ToString();

                            panel[x, y].Tag = SKU[nomorw];

                            labelNamaProduk[x, y] = new Label();
                            labelNamaProduk[x, y].Text = "" + dtWomen.Rows[i]["Nama"].ToString() + "";
                            labelNamaProduk[x, y].Size = new Size(170, 20);
                            labelNamaProduk[x, y].Location = new Point((((x + 0) * 193)), ((y + 0) * 220) + 130);
                            labelNamaProduk[x, y].BackColor = Color.LavenderBlush;
                            labelNamaProduk[x, y].TextAlign = ContentAlignment.MiddleCenter;

                            labelWarnaProduk[x, y] = new Label();
                            labelWarnaProduk[x, y].Text = "" + dtWomen.Rows[i]["Warna"].ToString() + "";
                            labelWarnaProduk[x, y].Size = new Size(170, 20);
                            labelWarnaProduk[x, y].Location = new Point((((x + 0) * 193)), ((y + 0) * 220) + 150);
                            labelWarnaProduk[x, y].BackColor = Color.LavenderBlush;
                            labelWarnaProduk[x, y].TextAlign = ContentAlignment.MiddleCenter;

                            labelHarga[x, y] = new Label();
                            labelHarga[x, y].Text = "$" + "" + dtWomen.Rows[i]["Harga"].ToString() + "";
                            labelHarga[x, y].Size = new Size(170, 30);
                            labelHarga[x, y].Location = new Point((((x + 0) * 193)), ((y + 0) * 220) + 170);
                            labelHarga[x, y].BackColor = Color.LavenderBlush;
                            labelHarga[x, y].TextAlign = ContentAlignment.MiddleCenter;

                            pbox[x, y] = new PictureBox();
                            //NGISI GAMBAR WOY             
                            sqlConnect = new MySqlConnection(connectString);
                            sqlQuery = "select J_FOTO from jam_tangan where J_SKU='" + SKU[nomorw] + "'";
                            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                            sqlAdapter = new MySqlDataAdapter(sqlCommand);
                            DataTable dtGambar = new DataTable();
                            sqlAdapter.Fill(dtGambar);
                            byte[] img = (byte[])dtGambar.Rows[0][0];

                            MemoryStream memoryStream = new MemoryStream(img);
                            pbox[x, y].Image = Image.FromStream(memoryStream);
                            sqlAdapter.Dispose();
                            pbox[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pbox[x, y].Size = new Size(95, 115);
                            pbox[x, y].Location = new Point((((x + 0) * 193) + 40), ((y + 0) * 220) + 10);
                            pbox[x, y].BackColor = Color.LavenderBlush;

                            pbox[x, y].Tag = SKU[nomorw];
                            panel[x, y].Tag = SKU[nomorw];
                            labelNamaProduk[x, y].Tag = SKU[nomorw];
                            labelWarnaProduk[x, y].Tag = SKU[nomorw];
                            labelHarga[x, y].Tag = SKU[nomorw];
                        }
                        bunifuPanelProdukWomen.Controls.Add(pbox[x, y]);
                        bunifuPanelProdukWomen.Controls.Add(labelHarga[x, y]);
                        bunifuPanelProdukWomen.Controls.Add(labelWarnaProduk[x, y]);
                        bunifuPanelProdukWomen.Controls.Add(labelNamaProduk[x, y]);
                        bunifuPanelProdukWomen.Controls.Add(panel[x, y]);

                        nomorw++;

                        pbox[x, y].Click += new EventHandler(pbox_click);
                        panel[x, y].Click += new EventHandler(panel_click);
                        labelHarga[x, y].Click += new EventHandler(harga_click);
                        labelWarnaProduk[x, y].Click += new EventHandler(warna_click);
                        labelNamaProduk[x, y].Click += new EventHandler(nama_click);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }


        private void bunifuButtonOff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuLabelaboutus_Click(object sender, EventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageAbout);
        }

        private void pictBoxCart_Click(object sender, EventArgs e)
        {
            showCart();
        }

        private void pictboxCart2_Click(object sender, EventArgs e)
        {
            showCart();
        }

        private void pictboxProfile2_Click(object sender, EventArgs e)
        {
            ShowProfile();
        }

        private void pictboxProfile3_Click(object sender, EventArgs e)
        {
            ShowProfile();
        }

        private void pictboxCart3_Click(object sender, EventArgs e)
        {
            showCart();
        }

        private void pictboxProfile4_Click(object sender, EventArgs e)
        {
            ShowProfile();
        }

        private void pictboxCart4_Click(object sender, EventArgs e)
        {
            showCart();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            try
            {
                labelProfileName.Text = FormSignIn.ProfileName;

                //AUTOGENERATE CART_ID
                IDCart = "C/";
                IDCart += FormSignIn.IDReseller.ToString();

                sqlConnect = new MySqlConnection(connectString);
                DataTable dtket = new DataTable();
                sqlQuery = "SELECT beli_jmlbrg as `Qty`, concat('$', beli_totalfinal) as `Price`, concat(beli_diskon, '%') as `Disc` from transaksi_pembelian where beli_id='" + IDCart.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtket);

                labelQtyCart.Text = dtket.Rows[0]["Qty"].ToString();
                labelQtyCart2.Text = dtket.Rows[0]["Qty"].ToString();
                labelQtyCart3.Text = dtket.Rows[0]["Qty"].ToString();
                labelQtyCart4.Text = dtket.Rows[0]["Qty"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButtonHome_Click(object sender, EventArgs e)
        {
            labelProfileName.Text = FormSignIn.ProfileName;
            bunifuPageHome.SelectTab(tabPageHome);
        }

        private void bunifuButtonMen_Click(object sender, EventArgs e)
        {
            try
            {
                labelProfileName2.Text = FormSignIn.ProfileName;
                bunifuPageHome.SelectTab(tabPageMen);
                int nomorm = 1;
                back = "Men";

                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        sqlConnect = new MySqlConnection(connectString);
                        DataTable dtMen = new DataTable();
                        sqlQuery = "select J_SKU, J_MERK as `Nama`, J_WARNA as `Warna`, J_HARGA as `Harga` from jam_tangan where J_SKU like 'M%' ";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(dtMen);
                        int i = nomorm - 1;

                        panel[x, y] = new Panel();
                        panel[x, y].Name = nomorm.ToString();
                        panel[x, y].Location = new Point((x + 0) * 193, (y + 0) * 220);
                        panel[x, y].Visible = true;
                        panel[x, y].Size = new Size(170, 200);
                        panel[x, y].BackColor = Color.LightCyan;


                        for (i = nomorm - 1; i <= nomorm - 1; i++)
                        {
                            SKU[nomorm] = dtMen.Rows[i][0].ToString();

                            panel[x, y].Tag = SKU[nomorm];
                            labelNamaProduk[x, y] = new Label();
                            labelNamaProduk[x, y].Text = "" + dtMen.Rows[i]["Nama"].ToString() + "";
                            labelNamaProduk[x, y].Size = new Size(170, 20);
                            labelNamaProduk[x, y].Location = new Point((((x + 0) * 193)), ((y + 0) * 220) + 130);
                            labelNamaProduk[x, y].BackColor = Color.LightCyan;
                            labelNamaProduk[x, y].TextAlign = ContentAlignment.MiddleCenter;

                            labelWarnaProduk[x, y] = new Label();
                            labelWarnaProduk[x, y].Text = "" + dtMen.Rows[i]["Warna"].ToString() + "";
                            labelWarnaProduk[x, y].Size = new Size(170, 20);
                            labelWarnaProduk[x, y].Location = new Point((((x + 0) * 193)), ((y + 0) * 220) + 150);
                            labelWarnaProduk[x, y].BackColor = Color.LightCyan;
                            labelWarnaProduk[x, y].TextAlign = ContentAlignment.MiddleCenter;

                            labelHarga[x, y] = new Label();
                            labelHarga[x, y].Text = "$" + "" + dtMen.Rows[i]["Harga"].ToString() + "";
                            labelHarga[x, y].Size = new Size(170, 30);
                            labelHarga[x, y].Location = new Point((((x + 0) * 193)), ((y + 0) * 220) + 170);
                            labelHarga[x, y].BackColor = Color.LightCyan;
                            labelHarga[x, y].TextAlign = ContentAlignment.MiddleCenter;

                            pbox[x, y] = new PictureBox();
                            //NGISI GAMBAR WOY             
                            sqlConnect = new MySqlConnection(connectString);
                            sqlQuery = "select J_FOTO from jam_tangan where J_SKU='" + SKU[nomorm] + "'";
                            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                            sqlAdapter = new MySqlDataAdapter(sqlCommand);
                            DataTable dtGambar = new DataTable();
                            sqlAdapter.Fill(dtGambar);
                            byte[] img = (byte[])dtGambar.Rows[0][0];

                            MemoryStream memoryStream = new MemoryStream(img);
                            pbox[x, y].Image = Image.FromStream(memoryStream);
                            sqlAdapter.Dispose();
                            pbox[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                            pbox[x, y].Size = new Size(95, 115);
                            pbox[x, y].Location = new Point((((x + 0) * 193) + 40), ((y + 0) * 220) + 10);
                            pbox[x, y].BackColor = Color.LightCyan;

                            pbox[x, y].Tag = SKU[nomorm];
                            panel[x, y].Tag = SKU[nomorm];
                            labelNamaProduk[x, y].Tag = SKU[nomorm];
                            labelWarnaProduk[x, y].Tag = SKU[nomorm];
                            labelHarga[x, y].Tag = SKU[nomorm];
                        }

                        //BIAR BISA MUNCUL
                        bunifuPanelProdukMen.Controls.Add(pbox[x, y]);
                        bunifuPanelProdukMen.Controls.Add(labelHarga[x, y]);
                        bunifuPanelProdukMen.Controls.Add(labelWarnaProduk[x, y]);
                        bunifuPanelProdukMen.Controls.Add(labelNamaProduk[x, y]);
                        bunifuPanelProdukMen.Controls.Add(panel[x, y]);

                        nomorm++;

                        pbox[x, y].Click += new EventHandler(pbox_click);
                        panel[x, y].Click += new EventHandler(panel_click);
                        labelHarga[x, y].Click += new EventHandler(harga_click);
                        labelWarnaProduk[x, y].Click += new EventHandler(warna_click);
                        labelNamaProduk[x, y].Click += new EventHandler(nama_click);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void tabPageProfile_Click(object sender, EventArgs e)
        {

        }

        //MINOQ
        private void buttonAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "set foreign_key_checks = 0";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                //buat nyari diskon
                DataTable dtmember = new DataTable();
                sqlQuery = "select m.M_ID as `ID`, M_DISKON as `Diskon` from membership m, reseller r where m.M_ID = r.M_ID and R_ID = '" + FormSignIn.IDReseller + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtmember);

                sqlQuery = "set foreign_key_checks = 0";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                //update transaksi pembelian
                totalharga = Convert.ToDouble(numQty.Value) * price;
                totalfinal = totalharga - ((totalharga * Convert.ToDouble(dtmember.Rows[0]["Diskon"]) / 100));
                totalfinalstring = totalfinal.ToString();
                totalfinalstring = totalfinalstring.Replace(",", ".");

                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "update transaksi_pembelian set beli_jmlbrg = beli_jmlbrg + '" + numQty.Value.ToString() + "', beli_totalharga = beli_totalharga + '" + totalharga.ToString() + "', beli_totalfinal = beli_totalfinal + '" + totalfinalstring + "' where beli_id ='" + IDCart.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                DataTable dtdetailbeli = new DataTable();
                sqlQuery = "select beli_id as `Beli ID`, J_SKU as `SKU` from detail_beli";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdetailbeli);

                //NYARI APAKAH ADA YANG SAMA ATAU NDAK
                for (int i = 0; i < dtdetailbeli.Rows.Count; i++)
                {
                    if (dtdetailbeli.Rows[0]["Beli ID"].ToString() == IDCart.ToString() && dtdetailbeli.Rows[0]["J_SKU"].ToString() == SKUAktif.ToString())
                    {
                        sama = 1;
                    }
                }

                sqlQuery = "set foreign_key_checks = 0";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                if (sama == 1)
                {
                    //update ke detail_beli
                    sqlQuery = "update detail_beli set db_qty = db_qty + '" + numQty.Value.ToString() + "', dr_price = dr_price + '" + price.ToString() + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }
                else
                {
                    //insert ke detail_beli
                    sqlQuery = "insert into detail_beli values('" + IDCart.ToString() + "', '" + SKUAktif.ToString() + "', '" + numQty.Value.ToString() + "', '" + price.ToString() + "', '0')";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }

                sqlQuery = "set foreign_key_checks = 0";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                //ngupdate stok di jam_tangan
                sqlQuery = "update jam_tangan set j_stok = j_stok - '" + numQty.Value.ToString() + "' where j_sku = '" + SKUAktif.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                qty = numQty.Value.ToString();
                showCart();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //INEZ
        private void showCart()
        {
            //NAMPILIN DGV
            bunifuPageHome.SelectTab(tabPageCart);
            DataTable dtcart = new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlQuery = "SELECT J_MERK as `Item`, J_UKURAN as `Size`, db_qty as `Qty`, dr_price as `Price` from jam_tangan j, detail_beli d, transaksi_pembelian t, reseller r where j.j_sku = d.j_sku and d.beli_id = t.beli_id and t.r_id = r.r_id and beli_acc = '2' and t.R_ID = '" + FormSignIn.IDReseller + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtcart);
            dgvCart.DataSource = dtcart;

            //BUAT NGISI LABEL
            DataTable dtket = new DataTable();
            sqlQuery = "SELECT beli_jmlbrg as `Qty`, concat('$', beli_totalfinal) as `Price`, concat(beli_diskon, '%') as `Disc` from transaksi_pembelian where beli_id='" + IDCart.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtket);

            labelDiskon.Text = dtket.Rows[0]["Disc"].ToString();
            labelHargaa.Text = dtket.Rows[0]["Price"].ToString();

            labelTotalQty.Text = dtket.Rows[0]["Qty"].ToString();
            labelQtyCart.Text = dtket.Rows[0]["Qty"].ToString();
            labelQtyCart2.Text = dtket.Rows[0]["Qty"].ToString();
            labelQtyCart3.Text = dtket.Rows[0]["Qty"].ToString();
            labelQtyCart4.Text = dtket.Rows[0]["Qty"].ToString();
            totalqty= dtket.Rows[0]["Qty"].ToString();
        }
        private void tabPageMen_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void tboxNoHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ini code biar yg masuk angka doang
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //MINOQ
        private void labelPurchaseHistory_Click(object sender, EventArgs e)
        {
            try
            {
                //HISTORY AJA
                bunifuPageHome.SelectTab(tabPageHistory);

                DataTable dtHistory = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "SELECT beli_tanggal as `Date`, beli_id as `ID`, beli_jmlbrg as `Quantity`, BELI_TOTALFINAL as `Price`, if(beli_acc=1, 'Accepted', if(beli_acc=0, 'Pending', '')) as `Status` from transaksi_pembelian t, reseller r, membership m where (beli_acc='1' or beli_acc='0') and t.R_ID=r.R_ID and r.m_id=m.m_id and t.r_id='" + FormSignIn.IDReseller + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHistory);
                dgvHistory.DataSource = dtHistory;
                IDBeli = dtHistory.Rows[0]["ID"].ToString();
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }
        
        //MINOQ
        private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DETAIL HISTORY
                bunifuPageHome.SelectTab(tabPageDetailHistory);

                DataTable dtHistory = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select j_merk as `Product Name`, concat(`j_warna`, ' (', `j_ukuran`, ')') as `Details`, db_qty as `Quantity`, dr_price as `Price ($)` from detail_beli d, jam_tangan j where d.j_sku=j.j_sku and BELI_ID='" + IDBeli + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHistory);
                dgvDetailHistory.DataSource = dtHistory;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBackProfile_Click(object sender, EventArgs e)
        {
            //BACK DARI HISTORY KE PROFILE
            bunifuPageHome.SelectTab(tabPageProfile);
        }

        private void buttonBackDetailHistory_Click(object sender, EventArgs e)
        {
            //BACK DARI DETAIL HISTORY KE HISTORY
            bunifuPageHome.SelectTab(tabPageHistory);
        }

        //INEZ
        private void bunifuLabel6_Click(object sender, EventArgs e)
        {
            try
            {
                if (back == "Kids")
                {
                    bunifuPageHome.SelectTab(tabPageKids);
                }
                else if (back == "Men")
                {
                    bunifuPageHome.SelectTab(tabPageMen);
                }
                else if (back == "Women")
                {
                    bunifuPageHome.SelectTab(tabPageWomen);
                }
                else if (back == "Top")
                {
                    bunifuPageHome.SelectTab(tabPageTop);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tboxEditNoHP_TextChanged(object sender, EventArgs e)
        {

        }

        //INEZ
        private void tboxEditNoHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ini code biar yg masuk angka doang
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //ZEFA
        private void buttonPayNow_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "set foreign_key_checks = 0";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                //AUTOGENERATE BELI_ID
                string IDBeli = "B/";
                var dt = DateTime.Now.ToString("yyyyMMdd");
                var tanggal = DateTime.Now.ToString("yyyy-MM-dd");
                tanggalbeli = DateTime.Now.ToString("yyyy-MM-dd");
                IDBeli += dt + "/";
                sqlQuery = "SELECT * FROM transaksi_pembelian where beli_id like 'B%'";
                DataTable dtBeli = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBeli);
                int jumlahTransaksi = dtBeli.Rows.Count + 1;
                if (jumlahTransaksi < 10)
                {
                    IDBeli += "0000";
                    IDBeli += jumlahTransaksi.ToString();
                }
                else if (jumlahTransaksi < 100)
                {
                    IDBeli += "000";
                    IDBeli += jumlahTransaksi.ToString();
                }
                else if (jumlahTransaksi < 1000)
                {
                    IDBeli += "00";
                    IDBeli += jumlahTransaksi.ToString();
                }
                else if (jumlahTransaksi < 10000)
                {
                    IDBeli += "0";
                    IDBeli += jumlahTransaksi.ToString();
                }
                else
                {
                    IDBeli += jumlahTransaksi.ToString();
                }

                sqlQuery = "set global foreign_key_checks = 0";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                //UPDATE TRANSAKSI PEMBELIAN DARI C JADI B
                sqlQuery = "update transaksi_pembelian set beli_id = '" + IDBeli.ToString() + "', beli_tanggal = '" + tanggal.ToString() + "', beli_acc = 0 where beli_id = '" + IDCart.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                sqlQuery = "set global foreign_key_checks = 0";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                //UPDATE DETAIL
                sqlQuery = "update detail_beli set beli_id = '" + IDBeli.ToString() + "' where beli_id = '" + IDCart.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                sqlQuery = "set foreign_key_checks = 0";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                //BUAT UPDATE CART BARU
                sqlQuery = "insert into transaksi_pembelian(BELI_ID, R_ID, BELI_DISKON, BELI_ACC, BELI_DELETE) values('" + IDCart.ToString() + "', '" + FormSignIn.IDReseller + "', '2.50', '2', '0')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                //DELETE REPORT
                sqlQuery = "DELETE FROM report_detail";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                //INSERT REPORT
                sqlQuery = "INSERT INTO report_detail values ('" + item.ToString() + "', '" + warna.ToString() + "', '" + size.ToString() + "', '" + qty.ToString() + "','" + price.ToString() + "', '" + IDBeli.ToString() + "', '" + FormSignIn.namares + "', '" + tanggalbeli.ToString() + "', '" + totalqty.ToString() + "', '" + totalfinal.ToString() + "')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                FormInv formInvoice = new FormInv();          
                formInvoice.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            numQty.Maximum = stock;
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPanelTop_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabelIDBELI_Click(object sender, EventArgs e)
        {

        }

        private void tboxSearch2_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void tboxSearchWOMEN_TextChanged(object sender, EventArgs e)
        {
          

           


        }

       

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {

        }

        //INEZ
        private void bunifuGradientPanelMen_Click(object sender, EventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageDetail);
            SKUAktif = "MDWCY/WE36";
            fill_detail();
        }

        private void bunifuGradientPanelWomen_Click(object sender, EventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageDetail);
            SKUAktif = "WDWPD/BN28";
            fill_detail();
        }

        private void bunifuGradientPanelKids_Click(object sender, EventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageDetail);
            SKUAktif = "KLEPS/WE27";
            fill_detail();
        }

        private void panelMen_Paint(object sender, PaintEventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageMen);
            SKUAktif = "MDWCY/WE36";
            fill_detail();
        }

        private void panelWomen_Paint(object sender, PaintEventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageWomen);
            bunifuGradientPanelWomen.Tag = "WDWPD/BN28";
            pboxTop2.Tag = "WDWPD/BN28";
            bunifuGradientPanelWomen.Click += new EventHandler(panel_click);
            pboxTop2.Click += new EventHandler(pbox_click);
        }

        private void panelKids_Paint(object sender, PaintEventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageKids);
            bunifuGradientPanelKids.Tag = "KLEPS/WE27";
            pboxTop3.Tag = "KLEPS/WE27";
            bunifuGradientPanelKids.Click += new EventHandler(panel_click);
            pboxTop3.Click += new EventHandler(pbox_click);
        }

        private void menclick(object sender, EventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageDetail);
            SKUAktif = "MDWCY/WE36";
            fill_detail();
        }

        private void womenclick(object sender, EventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageDetail);
            SKUAktif = "WDWPD/BN28";
            fill_detail();
        }

        private void kidsclick(object sender, EventArgs e)
        {
            bunifuPageHome.SelectTab(tabPageDetail);
            SKUAktif = "KLEPS/WE27";
            fill_detail();
        }
    }
    }


