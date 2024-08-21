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
                    SelecionarRetangulo();
                    break;

                case "Circuferencia":
                    SelecionarCircuferencia();
                    break;

                default:
                    break;
            }

            
        }

        private void ExibirBase(bool visivel)
        {
            txtBase.Enabled = visivel;
            lblBase.Visible = txtBase.Visible = visivel;           
        }
        private void ExibirAltura(bool visivel)
        {
            txtAltura.Enabled = visivel;
            lblAltura.Visible = txtAltura.Visible = visivel;
        }

        private void ExibirRaio(bool visivel)
        {
            txtRaio.Enabled = visivel;
            lblRaio.Visible = txtRaio.Visible = visivel;
        }
        private void ExibirComboTriangulo(bool visivel)
        {
            cmbTriangulo.Visible =  visivel;
        }
        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            ExibirComboTriangulo(false);
        }
        private void SelecionarRetangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            ExibirComboTriangulo(false);

        }
        private void SelecionarCircuferencia()
        {
            ExibirBase(false);
            ExibirAltura(false);
            ExibirRaio(true);
            ExibirComboTriangulo(false);
        }

        private void SelecionarTriangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            ExibirComboTriangulo(true);

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (cmbForma.Text.Equals("Quadrado"))
            {
                FormaGeometrica quadrado = new Quadrado() { Lado = Convert.ToInt32(txtBase.Text) };
                cmbObjetos.Items.Add(quadrado);
            }
            if (cmbForma.Text.Equals("Retangulo"))
            {
                FormaGeometrica retangulo = new Retangulo() { Lado = Convert.ToInt32(txtBase.Text),Lado2 = Convert.ToInt32(txtAltura.Text) } ;
                cmbObjetos.Items.Add(retangulo);
            } 
            if (cmbForma.Text.Equals("Circuferencia"))
            {
                FormaGeometrica circuferencia = new Circuferencia() { Raio = Convert.ToInt32(txtRaio.Text) };
                cmbObjetos.Items.Add(circuferencia);
            }
            
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;
            txtArea.Text = obj.CalcularArea().ToString();
            txtPerimetro.Text = obj.CalcularPerimetro().ToString();
        }
    }
}
