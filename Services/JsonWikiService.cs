using System.Net;
using System.Text.Json;
using WebProjeleri2022.Models;

namespace WebProjeleri2022.Services
{
    public class JsonWikiService
    {

        public WikiModel GetWikiModel(string term)
        {
            string url = string.Concat("https://api.agify.io/?name=", term);
            var json = new WebClient().DownloadString(url);
            return JsonSerializer.Deserialize<WikiModel>(json);

        }
        

    }
}
