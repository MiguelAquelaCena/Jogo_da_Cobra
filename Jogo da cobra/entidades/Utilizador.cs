using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_cobra.entidades
{
    internal class Utilizador
    {
        public string UserName { get; private set; }

        public string Password { get; private set; }

        public byte Level { get;  set; }

        public int Score { get; set; }

        public Utilizador(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Level = 1;
            Score = 0;
        }
    }
}
