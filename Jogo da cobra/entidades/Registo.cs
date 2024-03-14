using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_cobra.entidades
{
    public partial class Registo : Form
    {
        public Registo() => InitializeComponent();
        private void buttonCancelar_Click(object sender, EventArgs e) => this.Close();
        private void buttonVerPass_Click(object sender, EventArgs e)
        {
            if (Passe.UseSystemPasswordChar)
                Passe.UseSystemPasswordChar = false;
            else
                Passe.UseSystemPasswordChar = true;
        }
        private void buttonVerRepPass_Click(object sender, EventArgs e)
        {
            if (Confirm_Password.UseSystemPasswordChar)
                Confirm_Password.UseSystemPasswordChar = false;
            else
                Confirm_Password.UseSystemPasswordChar = true;
        }
        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            if (Username.Text != "" && Passe.Text == Confirm_Password.Text)
            {
                GrupoUtilizadores grupoUtilizador = new GrupoUtilizadores();
                grupoUtilizador.AdicionarJogador(Username.Text, Passe.Text);
                Inf.okReg = true;
                grupoUtilizador.GuardarDados();
                this.Close();



            }
        }

        private void Registo_Load(object sender, EventArgs e)
        {

        }

        private void BTConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
