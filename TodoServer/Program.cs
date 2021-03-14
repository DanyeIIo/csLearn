using System;
using System.Net;
using System.Text;

namespace TodoServer
{
    class Program
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
                var responseValue = "";

                if (req.Url.PathAndQuery.Equals("/Issue"))
                {
                    switch (req.HttpMethod)
                    {
                        case "GET":
                            {
                                responseValue = "Show issues";
                                reqContext.Response.StatusCode = 200;
                                break;
                            }
                        case "POST":
                            {
                                responseValue = "Add ISSUE";
                                reqContext.Response.StatusCode = 200;
                                break;
                            }
                        case "PUT":
                            {
                                responseValue = "Change Issue";
                                reqContext.Response.StatusCode = 200;
                                break;
                            }
                        case "PATCH":
                            {
                                responseValue = "Change issue as done";
                                reqContext.Response.StatusCode = 200;
                                break;
                            }
                        case "DELETE":
                            {
                                responseValue = "Remove issue";
                                reqContext.Response.StatusCode = 200;
                                break;
                            }

                        case "MYDELETE":
                            {
                                responseValue = "Remove issue";
                                reqContext.Response.StatusCode = 200;
                                break;
                            }
                        default:
                            responseValue = "Something went wrong";
                            break;
                    }
                }
                var stream = reqContext.Response.OutputStream;
                var bytes = Encoding.UTF8.GetBytes(responseValue);
                stream.Write(bytes, 0, bytes.Length);
                reqContext.Response.Close();
            }

            httpListener.Stop();
            httpListener.Close();
        }
    }
}
