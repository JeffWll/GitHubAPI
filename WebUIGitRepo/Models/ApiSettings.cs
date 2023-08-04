namespace WebUIGitRepo
{
    public class ApiSettings
    {
        public string ApiEndpoint { get; set; }

        public ApiSettings()
        {
            ApiEndpoint = "https://localhost:7030/v1/ListaRepositorios";
        }
    }
}
