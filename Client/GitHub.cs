using AppConsoleCSharp.Client.Model.Response;
using RestSharp;

namespace AppConsoleCSharp.Client;

public class GitHub
{
    private static string URL_GITHUB = "https://api.github.com";
    public static IList<RepositoryResponse> ListarTodosRepositorios(string usuario)
    {
        var restClientOptions = new RestClientOptions(URL_GITHUB);
        var restClient = new RestClient(restClientOptions);
        var restRequest = new RestRequest(string.Format("/users/{0}/repos", usuario));

        var todosRepositoriosDoUsuario = restClient.Get<List<RepositoryResponse>>(restRequest);
        return todosRepositoriosDoUsuario;
    }

}