using RestSharp;

namespace PaupersReddit.Models
{
    public class RDAL
    {
        public SWPost GetPost()
        {
            var client = new RestClient($"https://www.reddit.com/r/aww/.json");
            var request = new RestRequest();
            var response = client.GetAsync<SWPost>(request);
            SWPost d = response.Result;
            return d;

        }
    }
}