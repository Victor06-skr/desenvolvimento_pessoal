namespace aula1;

class Program
{
    static void Main(string[] args)
    {
        int idade1 = Ola("Victor", 2006);
        Console.WriteLine($"Victor tem {idade1} anos de idade.");

        int idade2 = Ola("Matheus", 2007);
        Console.WriteLine($"Matheus tem {idade2} anos de idade.");

        int idade3 = Ola("Edivaldo", 1980);
        Console.WriteLine($"Edivaldo tem {idade3} anos de idade.");

        int idade4 = Ola("Larissa", 2017);
        Console.WriteLine($"Larissa tem {idade4} anos de idade.");
    }

    public static int Ola(string nome, int anoNasc)
    {
        Console.WriteLine("Olá, seja bem vindo(a) " + nome);
        int idade = 2026 - anoNasc;
        return idade;
    }
}
