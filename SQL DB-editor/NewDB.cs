using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_DB_editor.Properties;
using System.Windows.Forms;

namespace SQL_DB_editor
{
    public partial class NewDB : Form
    {
        public NewDB()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!(txtdbName.Text == ""))
            {
                if (Settings.Default.create_mysql == true)
                {
                    Program.MySqlCreate(txtdbName.Text);
                }
                else
                {
                    saveFile.FileName = txtdbName.Text;
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        Program.SqliteCreate(saveFile.FileName);
                        txtdbName.Text = saveFile.FileName;
                    }
                    
                }
                this.Size = new Size(810, 430);
                this.Location = new Point(300, 180);
            } else
            {
                MessageBox.Show("Enter A Valid Database Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
         
            cmbTables.Items.Add(txtableName.Text);
            txtableName.Text = "";
            MessageBox.Show("Added New Table!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnaddCoumn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.create_mysql == true)
            {
                Program.MySqlNewTable(txtdbName.Text, cmbTables.Text, txtColumn.Text, cmbDatatype.Text, int.Parse(txtLength.Value.ToString()));
            }
            else
            {
                Program.SqliteNewTable(txtdbName.Text, cmbTables.Text, txtColumn.Text, cmbDatatype.Text, int.Parse(txtLength.Value.ToString()));
            }
            txtColumn.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
