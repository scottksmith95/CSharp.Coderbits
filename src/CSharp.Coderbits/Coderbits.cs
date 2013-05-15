using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharp.Coderbits
{
    public class Coderbits
    {
        const string PATH = "https://coderbits.com/";

        public CoderbitsModel GetProfile(string username)
        {
            return GetProfileAsync(username).Result;
        }

        public async Task<CoderbitsModel> GetProfileAsync(string username)
        {
            //Create HttpClient for making request for profile
            var client = new HttpClient();

            //Get profile response as a JSON string
            var jsonStringTask = client.GetStringAsync(PATH + username + ".json");

            //Await
            var jsonString = await jsonStringTask;

            //Convert to JSON string to Coderbits model
            var coderbitsModelTask = JsonConvert.DeserializeObjectAsync<CoderbitsModel>(jsonString);

            //Await
            var coderbitsModel = await coderbitsModelTask;

            //Return the model
            return coderbitsModel;
        }
    }
}
