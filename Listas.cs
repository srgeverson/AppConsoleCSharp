using AppConsoleCSharp;

public class Listas
{
    public static IList<long> Gerar1000NumerosAleatorio()
    {
        var numeros = new List<long>();
        var random = new Random();
        for (var i = 0; i < 1000; i++)
            numeros.Add(random.NextInt64());
        return numeros;
    }
}