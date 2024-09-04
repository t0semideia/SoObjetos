using System;

namespace WfaObjetos
{
    public class TrianguloIsoceles : Triangulo
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

        public override double CalcularArea()
        {
            if (lado2 >= 2 * lado)
            {
                throw new InvalidOperationException("Os valores fornecidos não formam um triângulo isósceles válido.");
            }

            // Calcula a altura usando a fórmula da altura de um triângulo isósceles
            double altura = Math.Sqrt(lado * lado - (lado2 / 2.0) * (lado2 / 2.0));
            return (lado2 * altura) / 2.0;
        }

        public override double CalcularPerimetro()
        {
            // Perímetro de um triângulo isósceles é a soma dos três lados
            return 2 * lado + lado2;
        }
        public override string ToString()
        {
            return $"Triangulo Isoceles ({lado}) ({lado2})";
        }
    }
}
