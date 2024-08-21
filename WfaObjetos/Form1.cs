using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    SelecionarQuadrado();
                    break;

                case "Triangulo":
                    SelecionarTriangulo();
                    break;

                case "Retangulo":

                    break;

                case "Circuferencia":

                    break;

                default:
                    break;
            }

            
        }

        private void ExibirBase(bool visivel)
        {
            txtBase.Visible = txtAltura.Visible = visivel;
        }
        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }
        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            lblBase.Visible = txtBase.Visible = true; 
            lblRaio.Visible = txtRaio.Visible = false;
        }

        private void SelecionarTriangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            cmbTriangulo.Visible = cmbForma.Text.Equals("Triangulo");
            lblBase.Visible = cmbForma.Text.Equals("Triangulo");
            lblAltura.Visible = cmbForma.Text.Equals("Triangulo");
            txtAltura.Visible = cmbForma.Text.Equals("Triangulo");
            txtBase.Visible = cmbForma.Text.Equals("Triangulo");
           
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (cmbForma.Text.Equals("Quadrado"))
            {

            }
        }
    }
}
