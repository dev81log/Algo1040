using System.Globalization;

namespace Uri1040;

internal static class Program
{
    private static void Main(string[] args)
    {
        var cv = CultureInfo.InvariantCulture;

        var n1 = double.Parse(Console.ReadLine(), cv);
        var n2 = double.Parse(Console.ReadLine(), cv);
        var n3 = double.Parse(Console.ReadLine(), cv);
        var n4 = double.Parse(Console.ReadLine(), cv);

        var media = (n1 + n2 + n3 + n4) / 4;
        Console.WriteLine("Media: " + media.ToString("F1", cv));

        switch (media)
        {
            case >= 7.0:
                Console.WriteLine("Aluno aprovado.");
                break;
            case <= 5.0:
                Console.WriteLine("Aluno reprovado.");
                break;
            default:
            {
                if (media is >= 5.0 and <= 6.9)
                {
                    Console.WriteLine("Aluno em exame.");
                    var mediaExame = double.Parse(Console.ReadLine(), cv);
                    var novaMedia = (media + mediaExame) / 2;
                    Console.WriteLine("Nota do exame: " + novaMedia.ToString("F1", cv));

                    switch (novaMedia)
                    {
                        case >= 5.0:
                            Console.WriteLine("Aluno aprovado.");
                            break;
                        case <= 4.9:
                            Console.WriteLine("Aluno reprovado");
                            break;
                        default:
                            Console.WriteLine("Erro ao achar esta média!");
                            break;
                    }
                }
                break;
            }
        }
    }
}