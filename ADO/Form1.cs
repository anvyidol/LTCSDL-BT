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

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pwInp.PasswordChar = '●';
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void winRd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            string server = serverInp.Text;
            string database = dbInp.Text;
            Boolean windowsMode = winRd.Checked ? true : false;
            string username = uNameInp.Text;
            string password = pwInp.Text;

            if (windowsMode)
            {
                ADO.ConnectWindowMode(server, database);
                
            }
            else {
                ADO.ConnectSQLMode(server, database, username, password);
                
            }

            Form2 home = new Form2();
            home.Owner = this;
            home.Show();
            this.Hide();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            ADO.Disconnect();
        }
    }
}
