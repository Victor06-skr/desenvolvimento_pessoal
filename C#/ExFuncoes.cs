namespace ExFuncoes;

class Program
{
    static void Main(string[] args)
    {
        // chama a função mensagem
        mensagem();
        Console.Write("Número: ");
        int numero = int.Parse(Console.ReadLine());
        // chama a função fatorial
        int fat = calculaFatorial(numero);
        Console.WriteLine("Fatorial = " + fat);
    }

    // declaração das funções
    static void mensagem()
    {
        Console.WriteLine("*** Calcula o Fatorial de um Número ***");
    }

    static int calculaFatorial(int n)
    {
        int fatorial = 1;
        for (int cont = 1; cont <= n; cont++)
        {
            fatorial = fatorial * cont;
        }
        return fatorial;
    }
}
