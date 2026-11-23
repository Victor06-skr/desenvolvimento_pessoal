namespace ExIMC;

class Program
{
    static void Main(string[] args)
    {
        //entrada de dados
        Console.Write("Peso: ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        //processamento de dados
        double imc = peso / (altura * altura);

        //saída de dados
        Console.WriteLine("IMC: {0:N2}", imc);

        if (imc < 20)
        {
            Console.WriteLine("Abaixo do peso.");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Peso ideal.");
        }
        else
        {
            Console.WriteLine("Acima do peso.");
        }
    }
}
