using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jogo_da_cobra.entidades
{
    internal class Cobra
    {
        public List<Point> Corpo { get; private set; }
        public short Tamanho { get; private set; }

        private Direcao direcao;


        public Cobra()
        {
            Corpo = new List<Point> { new Point(40, 40) };
            Tamanho = 1;
            direcao = Direcao.Right;
            Inf.pontos = 0;
        }
        public Point Cabeca
        {
            get
            {
                return Corpo.First();
            }
            private set { }
        }

        public void AumentarPontuacao()
        {
            Inf.pontos += 10;
        }

        public void Mover()
        {
            Point novaCabeca = Cabeca;
            switch (direcao)
            {
                case (Direcao.Up):
                    novaCabeca.Y -= 5;
                    break;
                case (Direcao.Down):
                    novaCabeca.Y += 5;
                    break;
                case (Direcao.Left):
                    novaCabeca.X -= 5;
                    break;
                case (Direcao.Right):
                    novaCabeca.X += 5;
                    break;

            }
            Corpo.Insert(0, novaCabeca);
            while (Corpo.Count > Tamanho) 
                Corpo.RemoveAt(Corpo.Count - 1);
        }

        public void Draw(Graphics graficos)
        {
            foreach (Point segmento in Corpo)
                graficos.FillRectangle(Brushes.Green, segmento.X, segmento.Y, 25, 25);
        }
        public void Grow()
        {
            Tamanho++;
        }
        public bool VerificarColisaoPropria()
        {
            return Corpo.Count > 1 && Corpo.Skip(1).Any(segmento => segmento == Cabeca);
        }

        public bool VerificarColisaoFronteira()
        {
            return Cabeca.X < 0 || Cabeca.X > Inf.SIZEW - 10 || Cabeca.Y < 0 || Cabeca.Y > Inf.SIZEW - 10;
        }

        public void HandleKeyPress(Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    direcao = Direcao.Up;
                    break;
                case Keys.Down:
                    direcao = Direcao.Down;
                    break;
                case Keys.Left:
                    direcao = Direcao.Left;
                    break;
                case Keys.Right:
                    direcao = Direcao.Right;
                    break;
            }
        }
    }
}

