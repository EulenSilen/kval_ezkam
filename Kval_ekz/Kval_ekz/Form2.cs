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
using System.Data.Sql;

namespace Kval_ekz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAB206_8;Initial Catalog=Kval_ekz;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string comand = string.Format("SELECT * FROM User WHERE Login = '" + textBox1.Text
                + "' AND Password = '" + textBox2.Text + "';");
                SqlCommand cheak = new SqlCommand(comand, con);
                con.Open();

                    MessageBox.Show("Добро пожаловать в систему");
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide(); 
            }
            finally { }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }
    }
}
