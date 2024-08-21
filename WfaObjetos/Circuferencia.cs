using System;

namespace WfaObjetos
{
    public class Circuferencia : FormaGeometrica
    {
        private int raio;

        public int Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double CalcularArea()
        {
           return Math.PI + Math.Pow(raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return (Math.PI + (raio * 2) * 2);
        }
    }
}
