using AppConsoleCSharp.Client;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Iniciando a execução do programa");
            //var repositotios = await GitHub.ListarTodosRepositorios("srgeverson");
            // var numeros = Listas.Gerar1000NumerosAleatorio();
            // var pagina = 20;
            // var paginaCorrente = 0;
            // for (int i = 0; i < numeros.Count; i++)
            //     foreach
            // var s = numeros.Skip(10);
            // var t = s.Take(20).ToList();
            //Console.WriteLine(string.Format("Tamanho lista {0}, skip {1} e take {2}", numeros.Count, s, t));
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(string.Format("Erro ocorrido durante a execução do programa: {0}", ex.Message));
        }
        finally
        {
            Console.WriteLine("Finalizando a execução do programa...");
        }
    }
}