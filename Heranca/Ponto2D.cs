using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Ponto2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Ponto2D()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Ponto2D(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public virtual string EscreverPonto()
        {
            return "Ponto 2D -> X = " + X + ", Y = " + Y;
        }
    }
}
