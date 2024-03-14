using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_cobra.entidades
{
     class Comida
    {
        public Point posicao { get; private set; }

        public Random RND { get; private set; }

        public Comida()
        {
            posicao = new Point(100,100);

            RND = new Random();
        }

        public void Draw(Graphics graficos)
        {
            graficos.FillEllipse(Brushes.Black, posicao.X, posicao.Y, 20, 20);
        }

        public void GerarNovaPosicao()
        {
            int x = RND.Next(20,Inf.SIZEW -20);
            int y = RND.Next(20, Inf.SIZEW - 20);
            posicao = new Point(x, y);
        }
        

    }
}
