using BenchmarkDotNet.Attributes;
using RestSharp;

namespace dotnet_json_benchmark_lab
{
    [MemoryDiagnoser]
    public class JsonBenchmarks
    {
        MarketTrades mNewtonsoftJson;
        string sNewtonsoftJson;
        MarketTrades mSystemTextJson;
        string sSystemTextJson;

        public string GetJsonMarketTrades()
        {
            var client = new RestClient("https://api.bitkub.com/api/market/trades?sym=THB_BTC&lmt=100000");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public class MarketTrades
        {
            public int Error { get; set; }
            public object[] Result { get; set; }
        }

        [Benchmark]
        public void NewtonsoftJsonDeserializeObject()
        {
            mNewtonsoftJson = Newtonsoft.Json.JsonConvert.DeserializeObject<MarketTrades>(GetJsonMarketTrades());
        }

        [Benchmark]
        public void SystemTextJsonDeserializeObject()
        {
            mSystemTextJson = System.Text.Json.JsonSerializer.Deserialize<MarketTrades>(GetJsonMarketTrades());
        }

        [Benchmark]
        public void NewtonsoftJsonSerializeObject()
        {
            sNewtonsoftJson = Newtonsoft.Json.JsonConvert.SerializeObject(mNewtonsoftJson);
        }

        [Benchmark]
        public void SystemTextJsonSerializeObject()
        {
            sSystemTextJson = System.Text.Json.JsonSerializer.Serialize(mSystemTextJson);
        }
    }
}
