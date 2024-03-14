using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Jogo_da_cobra.entidades
{
    internal class ListaUtilizador
    {
        private List<Utilizador> ListaUtilizadores;
        private string jsonFilePath = "fjsjc.json";
        public ListaUtilizador(List<Utilizador> listaUtilizadores)
        {
            ListaUtilizadores = new List<Utilizador>();
        }
        public void AdicionarJogador(String username, String password)
        {
            if (ListaUtilizadores.Exists(j => j.UserName == username))
            {
                MessageBox.Show("Opss!! Jogador com username ja existente!");
                return;
            }

            Utilizador nvJogador = new Utilizador(username, password);
            ListaUtilizadores.Add(nvJogador);
            MessageBox.Show($"Jogador {nvJogador.UserName}criado com sucesso!!!");
        }

        public void AtualizarDadosJogador(string user,byte nivel, int pontos)
        {
            Utilizador njogador=ListaUtilizadores.Find(j=>j.UserName== user);
            if (njogador != null)
            {
                njogador.Level = nivel;
                njogador.Score = pontos;
                MessageBox.Show($"Dados Jogador {njogador.UserName}Atualizados com sucesso!!!");

            }
            else
                MessageBox.Show("opss! Jogador nao encontrado!!");

        }
        public void GuardarDados()
        {
            string json = JsonConvert.SerializeObject(ListaUtilizadores);
            File.WriteAllText(jsonFilePath, json);
        }

        public void CarregarDados()
        {
            if(File.Exists(jsonFilePath)) { }
        }

    }
}


 






