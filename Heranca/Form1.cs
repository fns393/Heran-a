using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Criar_ponto_Click(object sender, EventArgs e)
        {
            double x, y, z;

            // Validação das caixas de texto usando o método ValidarCampo
            bool xValido = ValidarCampo(txt_X, out x);
            bool yValido = ValidarCampo(txt_Y, out y);
            bool zValido = ValidarCampo(txt_Z, out z);

            if (!xValido || !yValido || !zValido)
            {
                lbl_output.Text = "Existem valores inválidos!";
                return;
            }

            // Criar objeto
            Ponto3D ponto = new Ponto3D(x, y, z);

            // Mostrar resultado na Label
            lbl_output.Text = ponto.EscreverPonto();
        }

        private bool ValidarCampo(TextBox txt, out double valor)
        {
            if (double.TryParse(txt.Text, out valor))
            {
                txt.BackColor = Color.White; // válido
                return true;
            }
            else
            {
                txt.BackColor = Color.Red;   // inválido
                valor = 0;
                return false;
            }
        }
    }
}
