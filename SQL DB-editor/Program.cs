using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SQLite;

namespace SQL_DB_editor
{

   public static class Program
    {
        /**Project: SQL DB-editor v1.1
         * Date: 10/02/2020
         * Author: Stanley Brikkz
         * Github: @stanley47
         * Twitter: @stanlee_47
         * Website: https://keithstan.stanton.co.zw
        **/

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static void MySqlCreate(string dbName)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=;");
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn.Open();
                cmd = new MySqlCommand("CREATE SCHEMA `" + dbName + "`", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Created MySQL Database: " + dbName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }

        public static void SqliteCreate(string dbName)
        {
            SQLiteConnection liteconn = new SQLiteConnection();
           
            try
            {
                liteconn = new SQLiteConnection("Data Source=./"+ dbName +"");
                MessageBox.Show("Created SQLite Database: " + dbName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static void MySqlNewTable(string database, string tablename, string column, string datatype, int length)
        {
            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=;database='"+ database +"'");
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                try
                {
                    cmd = new MySqlCommand("CREATE TABLE `" + database + "`.`" + tablename + "` (`"+ column +"` "+ datatype +"("+ length +"))", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added New Column '"+ column +"' in Table '" + tablename +"'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Table '" + tablename + "' already exists")
                    {
                        cmd = new MySqlCommand("ALTER TABLE `" + database + "`.`" + tablename + "` ADD (`" + column + "` " + datatype + "(" + length + "))", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added New Column '" + column + "' in Table '" + tablename + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }

        public static void SqliteNewTable(string database, string tablename, string column, string datatype, int length)
        {
            SQLiteConnection liteconn = new SQLiteConnection("Data Source="+ database +"");
            SQLiteCommand litecmd = new SQLiteCommand();

            try
            {
                liteconn.Open();
                try
                {
                    litecmd = new SQLiteCommand("CREATE TABLE `" + tablename + "` (`" + column + "` " + datatype + "(" + length + "))", liteconn);
                    litecmd.ExecuteNonQuery();
                    MessageBox.Show("Added New Column '" + column + "' in Table '" + tablename + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("table `" + tablename + "` already exists"))
                    {
                        litecmd = new SQLiteCommand("ALTER TABLE `" + tablename + "` ADD `" + column + "` " + datatype + "(" + length + ")", liteconn);
                        litecmd.ExecuteNonQuery();
                        MessageBox.Show("Added New Column '" + column + "' in Table '" + tablename + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                liteconn.Close();
                litecmd.Dispose();
            }
        }
        public static void MySqlConnect(string address, ComboBox comboBox)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                conn = new MySqlConnection("server='" + address + "';userid=root;password=;");
                conn.Open();
                cmd = new MySqlCommand("SHOW DATABASES", conn);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                comboBox.DataSource = dt;
                comboBox.DisplayMember = "Database";
                comboBox.Text = "";
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

        public static void MysqlTables(string address, string database, ComboBox comboBox)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server='" + address + "';userid=root;password=;database='" + database + "'");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                conn.Open();
                cmd = new MySqlCommand("SHOW TABLES", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                comboBox.Items.Clear();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader.GetString(0));
                }
                MessageBox.Show("Retrieved Tables", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
