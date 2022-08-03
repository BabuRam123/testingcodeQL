using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
            string password = "hi";
            MessageBox.Show(password);
            String str = "server=MUNESH-PC;database=windowapp;UID=sa;password=123";

            String query = "select * from data";

            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("connect with sql server");

            con.Close();
        }
    }
}
