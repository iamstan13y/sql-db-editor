using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_DB_editor
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                this.Size = new Size(742, 502);
                this.WindowState = FormWindowState.Normal;
                panel1.Size = new Size(736, 444);
                btnClose.Location = new Point(682, 12);
                btnMax.Location = new Point(641, 12);
            }
            else
            {
                this.ClientSize = new Size(1320, 652);
                this.WindowState = FormWindowState.Maximized;
                panel1.Size = new Size(1365, 700);
                btnClose.Location = new Point(1320, 12);
                btnMax.Location = new Point(1280, 12);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            /*Main mainform = new Main();
            mainform.Show();*/
        }
    }
}
