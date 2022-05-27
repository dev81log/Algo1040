using System.Globalization;

namespace Uri1040;

internal static class Uri
{
    private static void Main(string[] args)
    {
        var cv = CultureInfo.InvariantCulture;

        var n1 = double.Parse(Console.ReadLine() ?? string.Empty, cv);
        var n2 = double.Parse(Console.ReadLine() ?? string.Empty, cv);
        var n3 = double.Parse(Console.ReadLine() ?? string.Empty, cv);
        var n4 = double.Parse(Console.ReadLine() ?? string.Empty, cv);

        var media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10;
        Console.WriteLine("Media: " + media.ToString("F1", cv));

        switch (media)
        {
            case >= 7.0:
                Console.WriteLine("Aluno aprovado.");
                break;
            case <= 5.0:
                Console.WriteLine("Aluno reprovado.");
                break;
            case >= 5.0 and <= 6.9:
            {
                Console.WriteLine("Aluno em exame.");
                var mediaExame = double.Parse(Console.ReadLine() ?? string.Empty, cv);
                Console.WriteLine("Nota do exame: " + mediaExame.ToString("F1", cv));

                var novaMedia = (media + mediaExame) / 2;

                switch (novaMedia)
                {
                    case >= 5.0:
                        Console.WriteLine("Aluno aprovado.");
                        Console.WriteLine("Media final: " + novaMedia.ToString("F1", cv));
                        break;
                    case <= 4.9:
                        Console.WriteLine("Aluno reprovado");
                        Console.WriteLine("Media final: " + novaMedia.ToString("F1", cv));
                        break;
                    default:
                        Console.WriteLine("Erro ao achar esta média!");
                        break;
                }

                break;
            }
        }
    }
}