using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SQL_DB_editor.Properties;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using LoadData;
using System.Data.SqlClient;

namespace SQL_DB_editor
{
    public partial class Main : Form
    {
        MySqlConnection conn = new MySqlConnection();
        SQLiteConnection liteConn = new SQLiteConnection();
        MySqlCommand cmd = new MySqlCommand();
        SQLiteCommand liteCmd = new SQLiteCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter(); 
        SQLiteDataAdapter liteAdapter = new SQLiteDataAdapter();
        Dataload dataload = new Dataload();
        public Main()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_MouseClick(object sender, MouseEventArgs e)
        {
            toolTip.Show("Select Database File", btnBrowse);
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            Program.MySqlConnect(txtAddress.Text, cmbDatabases);

        }

        private void cmbDatabases_SelectedValueChanged(object sender, EventArgs e)
        {
           // Program.MysqlTables(txtAddress.Text, cmbDatabases.SelectedValue.ToString(), cmbTables);
        }

        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                txtBrowsePath.Text = openFile.FileName;
            }
        }

        private void btnConnLite_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                liteConn = new SQLiteConnection("Data Source='" + txtBrowsePath.Text + "'");
                liteConn.Open();
                liteCmd = new SQLiteCommand(".table", liteConn);
                SQLiteDataReader reader = liteCmd.ExecuteReader();
                cmbTables.Items.Clear();
                while (reader.Read())
                {
                    cmbTables.Items.Add(reader.GetString(0));
                }
                MessageBox.Show("Retrieved Tables", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liteConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDatabases_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // Program.MysqlTables(txtAddress.Text, cmbDatabases.SelectedText, listBox1);
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            Program.MysqlTables(txtAddress.Text, cmbDatabases.SelectedText, cmbTables);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = new Table();
                conn = new MySqlConnection("server=127.0.0.1;userid=root;password=;database='" + cmbDatabases.Text + "'");
                dataload.MySqlLoad(cmbTables.SelectedText, conn, table.dgvTable);
                table.lblname.Text = cmbTables.SelectedText;
                table.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCreateSQL_Click(object sender, EventArgs e)
        {
            Settings.Default.create_mysql = true;
            Settings.Default.Save();
            NewDB newDB = new NewDB();
            newDB.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCreateLite_Click(object sender, EventArgs e)
        {
            Settings.Default.create_mysql = false;
            Settings.Default.Save();
            NewDB newDB = new NewDB();
            newDB.Show();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader reader;
            DataTable dt = new DataTable();

            try
            {
                conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Integrated Security=True"); //Connect " +
            //"Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrit" +
            //"e;MultiSubnetFailover=False");

                conn.Open();
                cmd = new SqlCommand("SELECT * FROM sys.databases", conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetString(0));
                }
                //adapter.SelectCommand = cmd;
                //adapter.Fill(dt);
                //listBox1.DataSource = dt;
                //listBox1.DisplayMember = "Database";
                //comboBox.Text = "";
                MessageBox.Show("Connection Succeeded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                adapter.Dispose();
            }
        }
    }
}
