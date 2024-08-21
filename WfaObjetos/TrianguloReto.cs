
using System;

namespace WfaObjetos
{
    public class TrianguloReto : Triangulo
    {
        private int lado;

        public int Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        private int lado2;

        public int Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }

        private int hipotenusa;

        public int Hipotenusa
        {
            get { return hipotenusa; }
            set { hipotenusa = value; }
        }



        public override double CalcularArea()
        {
            // Área de um triângulo retângulo é base * altura / 2
            return (lado * lado2) / 2.0;
        }

        public override double CalcularPerimetro()
        {
            // Perímetro é a soma dos três lados
            return lado + lado2 + CalcularHipotenusa();
        }

        public double CalcularHipotenusa()
        {
            // Hipotenusa usando o teorema de Pitágoras
            return Math.Sqrt(lado * lado + lado2 * lado2);
        }
    }
}