using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_cobra
{
    public partial class Jogo_da_cobra : Form
    {
        public Jogo_da_cobra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            tslAutor.Text = "© Miguel Costa";
            tslData.Text = DateTime.Now.ToLongDateString() + "|";
            tslHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslHora.Text += DateTime.Now.ToLongTimeString();
        }
    }
}
