using System.ComponentModel.DataAnnotations.Schema;

namespace GitHubAPI.Models
{
    public class GitRepositories
    {
        public string Url { get; set; }
        public string HtmlUrl { get; set; }
        public string CloneUrl { get; set; }
        public string GitUrl { get; set; }
        public string SshUrl { get; set; }
        public string SvnUrl { get; set; }
        public string MirrorUrl { get; set; }
        public long Id { get; set; }
        public string NodeId { get; set; }
        public Owner Owner { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool IsTemplate { get; set; }
        public string Description { get; set; }
        public string Homepage { get; set; }
        public string Language { get; set; }
        public bool Private { get; set; }
        public bool Fork { get; set; }
        public int ForksCount { get; set; }
        public int StargazersCount { get; set; }
        public int WatchersCount { get; set; }
        public string DefaultBranch { get; set; }
        public int OpenIssuesCount { get; set; }
        public DateTime PushedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //public Permissions Permissions { get; set; }
        //public LicenseReq License { get; set; }
        public bool HasIssues { get; set; }
        public bool HasWiki { get; set; }
        public bool HasDownloads { get; set; }
        public bool HasPages { get; set; }
        public int SubscribersCount { get; set; }
        public long Size { get; set; }
        public bool Archived { get; set; }
        //public IReadOnlyList<string> Topics { get; set; }
        public int Visibility { get; set; }
    }
    public class Owner
    {
        public bool SiteAdmin { get; set; }
        public bool Suspended { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string AvatarUrl { get; set; }
        
        public string Bio { get; set; }
        
        public string Blog { get; set; }
        
        public string Collaborators { get; set; }
        
        public string Company { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DiskUsage { get; set; }
        
        public string Email { get; set; }
        
        public int Followers { get; set; }
        public int Following { get; set; }
        public string Hireable { get; set; }
        
        public string HtmlUrl { get; set; }
        public int Id { get; set; }
        public string NodeId { get; set; }
        public string Location { get; set; }
        
        public string Login { get; set; }
        public string Name { get; set; }
        
        public int Type { get; set; }
        public int OwnedPrivateRepos { get; set; }
        public string Plan { get; set; }
        
        public string PrivateGists { get; set; }
        
        public int PublicGists { get; set; }
        public int PublicRepos { get; set; }
        public int TotalPrivateRepos { get; set; }
        public string Url { get; set; }
    }

    public class Permissions
    {
        public bool Admin { get; set; }
        public bool Maintain { get; set; }
        public bool Push { get; set; }
        public bool Triage { get; set; }
        public bool Pull { get; set; }
    }

    public class LicenseReq
    {
        public string Key { get; set; }
        public string NodeId { get; set; }
        public string Name { get; set; }
        public string SpdxId { get; set; }
        public string Url { get; set; }
        public bool Featured { get; set; }
    }
}
