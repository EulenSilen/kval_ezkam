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
    public partial class Form3 : Form

    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAB206_8;Initial Catalog=Kval_ekz;Integrated Security=True");
        SqlCommand cm = new SqlCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            {
                cm = new SqlCommand("insert into User(Familia,Name_Otchestvo,Login,Password) values(@Familia,@Name_Otchestvo,@Login,@Password)", con);
                cm.Parameters.AddWithValue(@"Familia", textBox1.Text);
                cm.Parameters.AddWithValue(@"Name_Otchestvo", textBox2.Text);
                cm.Parameters.AddWithValue(@"Login", textBox3.Text);
                cm.Parameters.AddWithValue(@"Password", textBox4.Text);
                con.Open();
                con.Close();
            }
            MessageBox.Show("Вы зарегистрировались");
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }
    }
}
