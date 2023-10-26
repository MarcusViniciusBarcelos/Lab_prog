class CalculadoraArea
{
    public double CalcularArea(double raio)
    {
        return Math.PI * raio * raio;
    }

    public double CalcularArea(double lado1, double lado2)
    {
        return lado1 * lado2;
    }
}