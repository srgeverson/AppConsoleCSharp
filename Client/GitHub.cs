using AppConsoleCSharp.Client.Model.Response;
using RestSharp;

namespace AppConsoleCSharp.Client;

public class GitHub
{
    private static string URL_GITHUB = "https://api.github.com";
    public static async Task<IList<RepositoryResponse>> ListarTodosRepositorios(string usuario)
    {
        var options = new RestClientOptions(URL_GITHUB);
        var client = new RestClient(options);
        var request = new RestRequest(string.Format("/users/{0}/repos", usuario));

        // The cancellation token comes from the caller. You can still make a call without it.
        var timeline = await client.GetAsync<RepositoryResponse>(request);
        return null;
    }

}