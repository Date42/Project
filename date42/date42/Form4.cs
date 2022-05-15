using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace date42
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Point İlkkonum;
        bool durum = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Mouse a tıklandığı anda. Burada sol yada sağ tıklanması farketmeyecektir.
            durum = true;
            this.Cursor = Cursors.SizeAll; // Fareyi taşıma şeklinde seçim yapılmış ikon halini almasını sağladık.
            İlkkonum = e.Location; /* İlk konum olarak fareye tam basıldığında e parametresinin Location özelliğini
                                    * kullanarak konum aldık. X ve Y koordinatlarını almış olduk.*/

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Mouse'u hareket ettirdiğimizde çalışacak kodlar.
            if (durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Mouse'u bıraktığımızda çalışacak kodlar.
            durum = false;
            this.Cursor = Cursors.Default; // Fare işaretçisi Default halini aldı.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void Form4_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=veri.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM alis_satis_verileri where seri_numara='" + form.id + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr["alis_tarihi"].ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Seri Numarasın Girin");
            }
        }
    }
}
