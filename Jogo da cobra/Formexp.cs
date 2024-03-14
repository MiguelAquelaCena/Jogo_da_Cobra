using Jogo_da_cobra.entidades;
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
    public partial class Formexp : Form
    {
        Cobra cobra;
        Comida comida;
        public Formexp()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            comida = new Comida();
            cobra = new Cobra();
            ClientSize = new System.Drawing.Size(Inf.SIZEW, Inf.SIZEW);

            timerJogo.Interval = 200;
            timerJogo.Tick += timerJogo_Tick;
            timerJogo.Start();
            this.BackColor = Color.Azure;
            this.Text = "Jogo da cobra";
            Inf.nivel = 1;
            Inf.pontos = 0;
        }

        private void timerJogo_Tick(object sender, EventArgs e)
        {
            cobra.Mover();
            tsHora.Text=DateTime.Now.ToLongTimeString();
        }

        private void Formexp_Paint(object sender, PaintEventArgs e)
        {
            comida.Draw(e.Graphics);
            cobra.Draw(e.Graphics);

        }

        private void Formexp_Load(object sender, EventArgs e)
        {

        }

        private void Formexp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("!!!!");
                InitializeGame();
            }
        }
    }
}
