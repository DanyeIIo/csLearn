using System;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Server
    {
        static void Main(string[] args)
        {
            var httpListener = new HttpListener();

            httpListener.Prefixes.Add("http://localhost:8100/");
            //httpListener.Prefixes.Add("http://127.0.0.1:8101/");

            httpListener.Start();
            while (true)
            {
                var reqContext = httpListener.GetContext();

                var req = reqContext.Request;

                if (req.Url.PathAndQuery.Equals("issue"))
                {
                    switch (req.HttpMethod)
                    {
                        case "GET":
                            {
                                Console.WriteLine("Show issues");
                                break;
                            }
                        case "POST":
                            {
                                Console.WriteLine("Add ISSUE");
                                break;
                            }
                        case "PUT":
                            {
                                Console.WriteLine("Change Issue");
                                break;
                            }
                        case "PATCH":
                            {
                                Console.WriteLine("Change issue as done");
                                break;
                            }
                        case "DELETE":
                            {
                                Console.WriteLine("Remove issue");

                                break;
                            }
                        default:
                            break;
                    }
                }
                while (true)
                {

                }
                reqContext.Response.StatusCode = 200;
                var stream = reqContext.Response.OutputStream;
                var text = "fuck your self";
                var bytes = Encoding.UTF8.GetBytes(text);
                stream.Write(bytes, 0, bytes.Length);
                reqContext.Response.Close();
            }
            
            httpListener.Stop();
            httpListener.Close();
            
            Console.WriteLine(HttpListener.IsSupported);

        }
    }
}
