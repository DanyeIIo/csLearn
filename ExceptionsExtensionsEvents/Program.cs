using System;
using System.IO;

namespace ExceptionsExtensionsEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var isContinue = true;
                var answer = GetUserAnswer("Input ur name", "Name of user");
                var user = new UserSubscriptions(answer);
                do
                {
                    answer = GetUserAnswer("Add new subscribe", "Name of Subscribe");
                    try
                    {
                        user.Add(new Subscription(answer));
                    }
                    catch (DuplicateException ex)
                    { 
                        Console.WriteLine(ex.Message);
                    }
                }
                while (isContinue);
            }
            catch (Exception ex)
            {
                File.AppendAllText("error.txt", ex.ToString());
                        throw ex;
            }
        }
        private static string GetUserAnswer(string message, string errorMessage)
        {
            Console.WriteLine(message);
            string answer = null;
            do
            {
                if (string.IsNullOrWhiteSpace(answer))
                {
                    answer = Console.ReadLine();
                }

            } while (string.IsNullOrWhiteSpace(answer));
            return answer;
        }
        public static void InnerExceprtions()
        {
            var generate = new ExceptionGenerator();
            generate.Generate();
        }
    }
}
