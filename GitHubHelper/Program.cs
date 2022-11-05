using System.Net.Http.Headers;
using GitHubHelper.Models;

RequestModel requestModel = new RequestModel();
var repos = requestModel.RepositoryName;
var owner = requestModel.AuthorName;
var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.UserAgent.Add(
        new ProductInfoHeaderValue("GitHubHelper", "1"));
Console.WriteLine("Enter owner name: ");
Console.WriteLine("Enter repos name: ");
var contentUrl = $"https://api.github.com/repos/{owner}/{repos}";


 