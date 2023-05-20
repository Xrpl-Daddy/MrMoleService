using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using XRPL.MrMoleService;

namespace ConsoleClient.Test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var api_key = "";
            var client = new MrMoleClient(true, api_key); //create client

            var subscribed = await client.GetSubscribedAccounts();
            Console.WriteLine(JObject.Parse(JsonConvert.SerializeObject(subscribed)));

            var current = await client.GetCurrentAccountInfo();
            Console.WriteLine(JObject.Parse(JsonConvert.SerializeObject(current)));

            var issuer = await client.GetIssuerInfo("rUetS7kbVYJZ76za5ywa1DgViNZMgT9Bvq");
            Console.WriteLine(JObject.Parse(JsonConvert.SerializeObject(issuer)));
            var issuer2 = await client.GetIssuerInfo("r3qWgpz2ry3BhcRJ8JE6rxM8esrfhuKp4R");
            Console.WriteLine(JObject.Parse(JsonConvert.SerializeObject(issuer2)));

            var token = await client.GetTokenInfo("rUetS7kbVYJZ76za5ywa1DgViNZMgT9Bvq", "RLT");
            Console.WriteLine(JObject.Parse(JsonConvert.SerializeObject(token)));

            var review = await client.GetReview(token.Data.reviews[0].uuid);
            Console.WriteLine(JObject.Parse(JsonConvert.SerializeObject(review)));




            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}