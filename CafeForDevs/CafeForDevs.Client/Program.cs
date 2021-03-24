using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace CafeForDevs.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var httpClient = new HttpClient();
            var baseCafeUri = new Uri("http://localhost:37820");
            var cafeHttpClient = new CafeHttpClient(httpClient, baseCafeUri);

            var application = new ClientApplication(cafeHttpClient);
            application.Start();

        }
        public static int[] arr(List<int> arr)
        {
            Random random = new Random();
            arr.ForEach(x =>
            {
                if (x.Equals(null) || x.Equals(0))
                {
                    x = random.Next(1, 100);
                }
            });
            return arr.ToArray();
        }
    }
}
