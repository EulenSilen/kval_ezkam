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
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cm = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=LAB206_8;Initial Catalog=Kval_ekz;Integrated Security=True");
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
        private void LoadData()
        {
            adapter = new SqlDataAdapter("SELECT * FROM Obuv", con);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.obuvTableAdapter.Fill(this.kval_ekzDataSet1.Obuv);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                        break;
                    case 1:
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Razmer_dopustimoi_skidki <=9";
                        break;
                    case 2:
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Razmer_dopustimoi_skidki >=10 AND Razmer_dopustimoi_skidki <=14";
                        break;
                    case 3:
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Razmer_dopustimoi_skidki >=15";
                        break;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            PaintRows();
        }
        private void PaintRows()
        {
            var c = System.Drawing.ColorTranslator.FromHtml("#7fff00");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (int.Parse(row.Cells[4].Value.ToString()) > 15)
                    {
                        row.DefaultCellStyle.BackColor = c;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }

                }
                catch { }
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\B320R5.jpg");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\D329H3.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\D572U8.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\F572H7.jpg");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\F635R4.jpg");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\G432E4.jpg");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\G783F5.jpg");
                    break;
                case 7:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\H782T5.jpg");
                    break;
                case 8:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\J384T6.jpg");
                    break;
                case 9:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-4\Desktop\Вариант 6\Импорт\Товар_import\А112Т4.jpg");
                    break;

            }
        }
    }
}
