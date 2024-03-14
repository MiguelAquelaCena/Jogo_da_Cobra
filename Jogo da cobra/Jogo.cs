using Jogo_da_cobra.entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_da_cobra
{
    public partial class Jogo : Form
    {
        private Comida comida;
        private Cobra cobra;

        public Jogo()
        {
            InitializeComponent();
            initializeGame();
        }
        private void initializeGame()
        {
            comida = new Comida();
            cobra = new Cobra();
            ClientSize = new System.Drawing.Size(Inf.SIZEW, Inf.SIZEW);

            TimerJogo.Interval = 200;
            TimerJogo.Tick += TimerJogo_Tick;
            TimerJogo.Start();
            this.BackColor = Color.Azure;
            this.Text = "Jogo da cobra";
            Inf.nivel = 1;
            Inf.pontos = 0;
        }

        private void jogo_Paint(object sender, PaintEventArgs e)
        {
            comida.Draw(e.Graphics);
            cobra.Draw(e.Graphics);
        }

        private void TimerJogo_Tick(object sender, EventArgs e)
        {
            tsHora.Text=DateTime.Now.ToLongTimeString();
            Atualizarinf();
            cobra.Mover();
            VerificarColisao();
            Invalidate();
        }

        private void Atualizarinf()
        {
            TsNivel.Text = "Nível: " + Inf.nivel.ToString();
            TsPontos.Text = "Pontuação: " +Inf.pontos.ToString();
        }

        private void Jogo_KeyDown(object sender, KeyEventArgs e)
        {
            cobra.HandleKeyPress(e.KeyCode);
        }

        private void VerificarColisao()
        {
            if (Math.Abs(cobra.Cabeca.X - comida.posicao.X) <= 20 && Math.Abs(cobra.Cabeca.Y - comida.posicao.Y) <= 20)
            {
                cobra.Grow();
                cobra.AumentarPontuacao();
                if (Inf.pontos % 50 == 0)
                {
                    Inf.nivel++;
                    TimerJogo.Interval -= 10;

                }
                comida.GerarNovaPosicao();
            }
            if (cobra.VerificarColisaoFronteira() || cobra.VerificarColisaoPropria())
                FimJogo();
        }

        private void FimJogo()
        {
            TimerJogo.Stop();
            MessageBox.Show($"Fim de jogo \nPontuaçao:{Inf.pontos}, \nNivel: {Inf.nivel}");
        }

        private void Jogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 && TimerJogo.Enabled == false)
                TimerJogo.Start();
            else if (e.KeyChar == 32 && TimerJogo.Enabled == true)
                TimerJogo.Stop();

            else if (e.KeyChar == 13)
                initializeGame();

        }
    }
}
