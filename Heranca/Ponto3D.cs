using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Ponto3D : Ponto2D
    {
        public double Z { get; set; }

        public Ponto3D() : base()
        {
            this.Z = 0;
        }

        public Ponto3D(double X, double Y, double Z) : base(X, Y)
        {
            this.Z = Z;
        }

        public override string EscreverPonto()
        {
            return "Ponto 3D -> X = " + X + ", Y = " + Y + ", Z = " + Z;
        }
    }
}
