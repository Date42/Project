using System;
using System.Drawing;
using System.Windows.Forms;

namespace date42
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

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


        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            form.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }
    }
}