namespace Boletim;

class Program
{
    static void Main(string[] args)
    {
        // coleta de dados
        string aluno = PedirNomeAluno();
        double nota1 = PedirNota("Informe a primeira nota: ");
        double nota2 = PedirNota("Informe a segunda nota: ");
        double nota3 = PedirNota("Informe a terceira nota: ");

        // processamento de dados
        double media = CalcularMedia(nota1, nota2, nota3);
        string situacao = VerificarSituacao(media);

        // saida de dados
        ApresentarResultado(aluno, media, situacao);
    }

// FUNÇÃO DO CÓDIGO
    public static string PedirNomeAluno()
    {
        Console.Write("Informe seu nome: ");
        string nome = Console.ReadLine();
        return nome;
    }

    public static double PedirNota(string msg)
    {
        Console.Write(msg);
        double nota1 = double.Parse(Console.ReadLine());
        return nota1;
    }

    public static double CalcularMedia(double n1, double n2, double n3)
    {
        double media = (n1 + n2 + n3) / 3;
        return media;
    }

    public static string VerificarSituacao(double media)
    {
        string situacao = "";
        if (media >= 6)
        {
            situacao = "aprovado";
        }
        else
        {
            situacao = "DP KKKKKKKKKKKKKKKKKKKK";
        }
        return situacao;
    }

    public static void ApresentarResultado(string nome, double media, string situacao)
    {
        Console.WriteLine("-- RESULTADO --");
        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Situação: {situacao}"); 
    }
}
