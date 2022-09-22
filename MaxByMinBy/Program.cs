using System.Text.Json;

public class Cidade
{
    public string Nome { get; set; }
    public string Pais { get; set; }
    public int Populacao { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var seisMaioresCidades = new Cidade[]
        {
                new () { Nome = "Cairo", Pais = "Egito", Populacao = 20076000 },
                new () { Nome = "Cidade do Mexico", Pais = "Mexico", Populacao = 21581000 },
                new () { Nome = "Delhi", Pais = "India", Populacao = 28514000 },
                new () { Nome = "Sao Paulo", Pais = "Brasil", Populacao = 21650000 },
                new () { Nome = "Shanghai", Pais = "China", Populacao = 25582000 },
                new () { Nome = "Toquio", Pais = "Japao", Populacao = 37400068 }
        };

        Console.WriteLine(
            $"Dados das 6 maiores cidades: {JsonSerializer.Serialize(seisMaioresCidades)}");

        Console.WriteLine();
        var maiorCidade = seisMaioresCidades.MaxBy(c => c.Populacao);
        Console.WriteLine($"Maior cidade do mundo em população: {maiorCidade.Nome} | " +
            $"País: {maiorCidade.Pais} | População: {maiorCidade.Populacao}");

        Console.WriteLine();
        var sextaMaiorCidade = seisMaioresCidades.MinBy(c => c.Populacao);
        Console.WriteLine($"6a. maior cidade do mundo em população: {sextaMaiorCidade.Nome} | " +
            $"País: {sextaMaiorCidade.Pais} | População: {sextaMaiorCidade.Populacao}");
    }
}