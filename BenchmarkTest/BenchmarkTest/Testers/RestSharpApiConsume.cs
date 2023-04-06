using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using TesteBenchmarkApi;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace BenchmarkTest.Testers
{
    [RankColumn]
    [MemoryDiagnoser]
    public class RestSharpApiConsume
    {
        /*[Benchmark]
        public async Task<string> RestClientConsume()
        {
            string domain = "https://localhost:7291/";
            string resource = "WeatherForecast";

            var client = new RestClient(domain);
            var request = new RestRequest(resource);
            request.Method = Method.Get;

            var response = await client.ExecuteAsync(request);

            return response.Content;
        }

        [Benchmark]
        public async Task<string> HttpClientConsume()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri("https://localhost:7291/");
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync("WeatherForecast");

                if (response.IsSuccessStatusCode)
                {  //GET
                    var retorno = await response.Content.ReadAsStringAsync();
                    return retorno;
                }
                else
                {
                    return "Error while doing request";
                }
            }
        }*/

        [Benchmark]
        public async Task<string> RestClientConsume()
        {
            string domain = "https://localhost:7291/";
            string resource = "WeatherForecast";

            var client = new RestClient(domain);
            var request = new RestRequest(resource);
            request.Method = Method.Post;
            var body = @"{
                        " + "\n" +
                        @"    ""consumer"": ""RestClient"",
                        " + "\n" +
                        @"    ""date"": ""25/05/2022""
                        " + "\n" +
                        @"}";
            request.AddStringBody(body, DataFormat.Json);

            var response = await client.ExecuteAsync(request);

            return response.Content;
        }

        [Benchmark]
        public async Task<string> HttpClientConsume()
        {
            var cliente = new HttpClient();

            cliente.BaseAddress = new Uri("https://localhost:7291/");
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // HTTP POST - define o produto
            var body = new Body { Consumer = "HttpClient", Date = "25/05/2022" };
            HttpResponseMessage response = await cliente.PostAsJsonAsync("WeatherForecast", body);

            if (response.IsSuccessStatusCode)
            {  //GET
                var retorno = await response.Content.ReadAsStringAsync();
                return retorno;
            }
            else
            {
                return "Error while doing request";
            }
        }
    }
}
