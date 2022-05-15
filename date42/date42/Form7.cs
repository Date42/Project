using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date42
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 from = new Form2();
            from.Show();
            this.Close();
        }
    }
}
