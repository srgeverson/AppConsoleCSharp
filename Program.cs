using AppConsoleCSharp.Client;

internal class Program
{
    private const int TAMANHO_PAGINA = 09;

    private static async Task Main(string[] args)
    {
        try
        {
            Console.WriteLine("Iniciando a execução do programa");
            #region Lista de repositórios
            var repositotios = GitHub.ListarTodosRepositorios("srgeverson");
            Console.WriteLine(string.Format("Total de repositórios {0}", repositotios.Count));
            var contadorDePagina = 0;
            var itensDaPagina = repositotios.Take(TAMANHO_PAGINA);
            while (itensDaPagina.Count() > 0)
            {
                contadorDePagina++;
                var contadorDeItemPorPagina = 0;
                foreach (var item in itensDaPagina)
                {
                    contadorDeItemPorPagina++;
                    Console.WriteLine(string.Format("Página {0}, item {1} de {2}. Nome do repositório {3}", contadorDePagina, contadorDeItemPorPagina, TAMANHO_PAGINA, item.name));
                }
                itensDaPagina = repositotios.Skip(TAMANHO_PAGINA * contadorDePagina).Take(TAMANHO_PAGINA);
            }
            #endregion

            #region lista de números
            var numeros = Listas.Gerar1000NumerosAleatorio();
            Console.WriteLine(string.Format("Total de números {0}", numeros.Count));
            var numerosDaPagina = numeros.Take(TAMANHO_PAGINA);
            contadorDePagina = 0;
            while (numerosDaPagina.Count() > 0)
            {
                contadorDePagina++;
                var contadorDeItemPorPagina = 0;
                foreach (var item in numerosDaPagina)
                {
                    contadorDeItemPorPagina++;
                    Console.WriteLine(string.Format("Página {0}, item {1} de {2}. Nome do repositório {3}", contadorDePagina, contadorDeItemPorPagina, TAMANHO_PAGINA, item));
                }
                numerosDaPagina = numeros.Skip(TAMANHO_PAGINA * contadorDePagina).Take(TAMANHO_PAGINA);
            }
            #endregion
            #region Operações pelo CMD
            //OperacaoCMD.IteragirComCMD();
            #endregion
        }
        catch (Exception ex)
        {
            Console.WriteLine(string.Format("Erro ocorrido durante a execução do programa: {0}", ex.Message));
        }
        finally
        {
            Console.WriteLine("Finalizando a execução do programa...");
        }
    }
}