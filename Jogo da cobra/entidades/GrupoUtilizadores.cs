using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_cobra.entidades
{
    internal class GrupoUtilizadores
    {
        private List<Utilizador> lsJogadores;
        private string jsonFilePath = "jfjcac.json";
        public GrupoUtilizadores()
        {
            if (File.Exists(jsonFilePath)) CarregarDados();
            else
                lsJogadores = new List<Utilizador>();
        }
        public void AdicionarJogador(string username, string password)
        {
            // Verifica se o utilizador já existe
            if (lsJogadores.Exists(j => j.UserName == username))
            {
                MessageBox.Show("Oppss!! Username já existente!!");
                return;
            }
            Utilizador nvJogador = new Utilizador(username, password);
            lsJogadores.Add(nvJogador);
            MessageBox.Show("Novo Jogador criado com sucesso!!");
        }
        public void AtualizarDadosDoJogador(string username, byte level, short score)
        {
            Utilizador nvJogador = lsJogadores.Find(j => j.UserName == username);
            if (nvJogador != null)
            {
                nvJogador.Level = level;
                nvJogador.Score = score;
                MessageBox.Show("Dados do jogador atualizados com sucesso!!");
            }
            else MessageBox.Show("Opss!!O Jogador não foi encontrado!!!");
        }
        public void GuardarDados()
        {
            string json = JsonConvert.SerializeObject(lsJogadores, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }
        public void CarregarDados()
        {
            string json = File.ReadAllText(jsonFilePath);
            lsJogadores = JsonConvert.DeserializeObject<List<Utilizador>>(json);
        }
        private bool UserExists(string username)
        {
            return lsJogadores.Any(u => u.UserName == username);
        }
        public bool Login(string username, string password)
        {
            Utilizador jogador;
            if (File.Exists(jsonFilePath)) CarregarDados();
            jogador = lsJogadores.Find(u => u.UserName == username);
            if (jogador != null && jogador.Password == password)
            {
                Inf.user = username;
                Inf.pontos = jogador.Score;
                Inf.nivel = jogador.Level;
                return true;
            }
            else
            {
                MessageBox.Show("Username/password incorretos!!" +
                "\nErro! na pesquisa do jogador com este username e " +
                "password: " + username + ", " + password);
                return false;

            }

            }
        }
    }

