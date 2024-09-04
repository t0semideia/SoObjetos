
using System;

namespace WfaObjetos
{
    public class TrianguloEquilatero : Triangulo
    {
        private int lado;

        public int Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return (Math.Sqrt(3) / 4) * lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 3 * lado;
        }
        public override string ToString()
        {
            return $"Triangulo Equilatero ({lado})";
        }
    }
}
