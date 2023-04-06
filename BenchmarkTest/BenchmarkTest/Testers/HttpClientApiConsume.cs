using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest.Testers
{
    [MemoryDiagnoser]
    public class HttpClientApiConsume
    {
        [Benchmark]
        public async Task<string> ConsumeRequest()
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
        }
    }
}
