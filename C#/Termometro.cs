class Termometro
{
    public double PedirTemperatura()
    {
        Console.Write("\nInforme a temperatura: ");
        double temp = double.Parse(Console.ReadLine());
        return temp;
    }


}