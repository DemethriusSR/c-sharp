namespace POO_01
{
    class Triangulo
        {
            public double A;//Encapsulamento
            public double B;
            public double C;

            public double CalculaArea()
            {
                double p = (A + B + C) / 2;
                double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                return area;
            }
            
        }
}
