using System;
using System.IO;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Header", "Value Beta Test");

                    var response = httpClient.GetAsync("http://localhost:8100/").Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(content);
                    //File.WriteAllText("index.html", content);
                }
            }
        }
    }
}