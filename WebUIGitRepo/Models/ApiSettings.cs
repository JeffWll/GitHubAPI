namespace WebUIGitRepo
{
    public class ApiSettings
    {
        public string ApiGetEndpoint { get; set; }
        public string ApiPostEndpoint { get; set; }

        public ApiSettings()
        {
            ApiGetEndpoint = "https://localhost:7030/v1/ListaRepositorios";
            ApiPostEndpoint = "https://localhost:7030/v1/";
        }
    }
}
