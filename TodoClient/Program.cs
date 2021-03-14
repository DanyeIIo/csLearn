using System;
using System.Net.Http;
using System.Text;

namespace TodoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool isContinut = true;
            while (isContinut)
            {
                Console.WriteLine("1-> Print Issues");
                Console.WriteLine("2-> Create Issues");
                Console.WriteLine("3-> Delete task");
                Console.WriteLine("4-> Set task");
                Console.WriteLine("5-> Edit Issue as done");
                Console.WriteLine("0-> Exit");
                Operation operationEnum = new Operation();
                if (int.TryParse(Console.ReadLine(), out int choose))
                {
                    if (Enum.IsDefined(typeof(Operation), choose))
                    {
                        operationEnum = (Operation)choose;
                    }
                }
                switch (operationEnum)
                {
                    case Operation.ShowIssue:
                        {
                            PrintIssues();
                            break;
                        }
                    case Operation.AddIssue:
                        {
                            CreateIssue();
                            break;
                        }
                    case Operation.RemoveIssue:
                        {
                            DeleteIssue();
                            break;
                        }
                    case Operation.EditIssue:
                        {
                            EditIssue();
                            break;
                        }
                    case Operation.SetIssueAsDone:
                        {
                            SetAsDoneIssue();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        private static void SetAsDoneIssue()
        {
            var httpClient = new HttpClient();
            var response = httpClient.PatchAsync("http://localhost:8100/Issue",null).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(content);
        } 
        private static void DeleteIssue()
        {
            var httpClient = new HttpClient();
            var response = httpClient.DeleteAsync("http://localhost:8100/Issue").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(content);
        }
        private static void EditIssue()
        {
            var httpClient = new HttpClient();
            var response = httpClient.PutAsync("http://localhost:8100/Issue", null).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(content);
        }
        private static void CreateIssue()
        {
            var httpClient = new HttpClient();
            var response = httpClient.PostAsync("http://localhost:8100/Issue", null).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(content);
        }
        private static void PrintIssues()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("http://localhost:8100/Issue").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(content);
        }
    }
}
