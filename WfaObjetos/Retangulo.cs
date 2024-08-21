namespace WfaObjetos
{
    public class Retangulo : FormaGeometrica
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
            return lado * lado2;
        }

        public override double CalcularPerimetro()
        {
           return 2*(lado2 + lado);
        }
    }
}
