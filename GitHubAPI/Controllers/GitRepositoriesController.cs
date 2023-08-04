using GitHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using Microsoft.Extensions.Configuration;

namespace GitHubAPI.Controllers
{
    [ApiController]
    [Route(template:"v1")]
    public class GitRepositoriesController : ControllerBase 
    {
        private readonly GitHubClient _gitHubClient;
        private readonly IConfiguration _configuration;
        public GitRepositoriesController(IConfiguration configuration)
        {
            _configuration = configuration;

            var gitHubToken = _configuration["GitHubToken"];
            var productInformation = new ProductHeaderValue(_configuration["ProductInformation"]);
            _gitHubClient = new GitHubClient(productInformation)
            {
                Credentials = new Credentials(gitHubToken)
            };
        }

        [HttpGet]
        [Route("ListaRepositorios/{palavraChave}/{linguagemId}")]
        public async Task<ActionResult<List<Repository>>> GetListaRepositorios(string palavraChave, int linguagemId)
        {
            try
            {
                Language linguagemSelecionada = GetSelectedLanguage(linguagemId);

                var request = new SearchRepositoriesRequest(palavraChave)
                {
                    Language = linguagemSelecionada,
                };

                var result = await _gitHubClient.Search.SearchRepo(request);
                var repositories = result.Items;

                var gitRepositories = CreateGitRepositoriesList(repositories);

                return Ok(repositories);
            }
            catch (ApiException ex)
            {
                return StatusCode((int)ex.StatusCode, ex.Message);
            }
        }
        
        [HttpPost]
        [Route("SalvarRepositoriosEscolhidos")]
        public IActionResult SalvarRepositoriosEscolhidos(List<GitRepositories> repositoriosEscolhidos)
        {
            return Ok();
        }
        private Language GetSelectedLanguage(int linguagemId)
        {
            switch (linguagemId)
            {
                case 1:
                    return Language.CSharp;
                case 2:
                    return Language.JavaScript;
                case 3:
                    return Language.Kotlin;
                case 4:
                    return Language.C;
                case 5:
                    return Language.Java;
                default:
                    return Language.CSharp;
            }
        }
        private List<GitRepositories> CreateGitRepositoriesList(IEnumerable<Repository> repositories)
        {
            var gitRepositories = new List<GitRepositories>();

            foreach (var repository in repositories)
            {
                var gitRepo = new GitRepositories
                {
                    Url = repository.Url,
                    HtmlUrl = repository.HtmlUrl,
                    CloneUrl = repository.CloneUrl,
                    GitUrl = repository.GitUrl,
                    SshUrl = repository.SshUrl,
                    SvnUrl = repository.SvnUrl,
                    MirrorUrl = repository.MirrorUrl,
                    Id = repository.Id,
                    NodeId = repository.NodeId,
                    Owner = new Owner
                    {
                        SiteAdmin = repository.Owner.SiteAdmin,
                        Suspended = repository.Owner.Suspended,
                        AvatarUrl = repository.Owner.AvatarUrl,
                        Bio = repository.Owner.Bio,
                        Blog = repository.Owner.Blog,
                        Company = repository.Owner.Company,
                        Email = repository.Owner.Email,
                        Followers = repository.Owner.Followers,
                        Following = repository.Owner.Following,
                        HtmlUrl = repository.Owner.HtmlUrl,
                        Id = repository.Owner.Id,
                        NodeId = repository.Owner.NodeId,
                        Location = repository.Owner.Location,
                        Login = repository.Owner.Login,
                        Name = repository.Owner.Name,
                        OwnedPrivateRepos = repository.Owner.OwnedPrivateRepos,
                        PublicGists = repository.Owner.PublicGists,
                        PublicRepos = repository.Owner.PublicRepos,
                        TotalPrivateRepos = repository.Owner.TotalPrivateRepos,
                        Url = repository.Owner.Url
                    },
                    Name = repository.Name,
                    FullName = repository.FullName,
                    IsTemplate = repository.IsTemplate,
                    Description = repository.Description,
                    Homepage = repository.Homepage,
                    Language = repository.Language,
                    Private = repository.Private,
                    Fork = repository.Fork,
                    ForksCount = repository.ForksCount,
                    StargazersCount = repository.StargazersCount,
                    WatchersCount = repository.WatchersCount,
                    DefaultBranch = repository.DefaultBranch,
                    OpenIssuesCount = repository.OpenIssuesCount,
                    HasIssues = repository.HasIssues,
                    HasWiki = repository.HasWiki,
                    HasDownloads = repository.HasDownloads,
                    HasPages = repository.HasPages,
                    SubscribersCount = repository.SubscribersCount,
                    Size = repository.Size,
                    Archived = repository.Archived
                };

                gitRepositories.Add(gitRepo);
            }

            return gitRepositories;
        }

    }
}
