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
    public partial class Login : Form
    {
        public Login() => InitializeComponent();
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (Username.Text == "123" && Passe.Text == "123")
            {
                this.Hide();
                Jogo frm = new Jogo();
                frm.ShowDialog();
            }
            else
            {
                Inf.jogadores = new GrupoUtilizadores();
                bool loginSuccessful = Inf.jogadores.Login(Username.Text, Passe.Text);
                if (loginSuccessful)
                {
                    this.Hide();
                    Jogo_da_cobra frm = new Jogo_da_cobra();
                    frm.ShowDialog();
                }
            }
        }
        private void buttonVerPass_MouseHover(object sender, EventArgs e)
        {
            Username.UseSystemPasswordChar = false;
        }
        private void buttonVerPass_MouseLeave(object sender, EventArgs e)
        {
            Passe.UseSystemPasswordChar = true;
        }
        private void buttonRegisto_Click(object sender, EventArgs e)
        {
            Registo frm = new Registo();
            frm.ShowDialog();
            if (Inf.okReg) this.Close();
        }
        private void buttonVerPass_Click(object sender, EventArgs e)
        {
            if (Passe.UseSystemPasswordChar)
                Passe.UseSystemPasswordChar = false;
            else
                Passe.UseSystemPasswordChar = true;
        }
        private void buttonCancelar_Click(object sender, EventArgs e) => this.Close();

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

