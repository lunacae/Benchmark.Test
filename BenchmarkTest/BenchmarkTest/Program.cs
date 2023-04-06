using BenchmarkDotNet.Running;
using BenchmarkTest.Testers;

class Benchmark
{
    public static async Task Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine("Pressione algo para iniciar");
        Console.ReadKey();

        var restApi = new RestSharpApiConsume();
        var resultado = BenchmarkRunner.Run<RestSharpApiConsume>();

        /*var HttpClientApi = new HttpClientApiConsume();
        var retorno = await HttpClientApi.ConsumeRequest();
        Console.WriteLine($"Retorno da Api: {retorno}");*/

        /*var RestSharpConsume = new RestSharpApiConsume();
        var retorno = await RestSharpConsume.HttpClientConsume();*/

        //Console.WriteLine(retorno);
    }
}