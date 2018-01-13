using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpAsyncAwait
{
    class Program
    {
        static async Task<string> Download(string url)
        {
            using (var client = new WebClient())
            {
                Console.WriteLine($"download - {url}");

                client.Headers.Add("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.13; rv:58.0) Gecko/20100101 Firefox/58.0");
                var task = await Task.Factory.StartNew(() => client.DownloadString(url));

                Console.WriteLine($"complete - {url}");
                return task;
            }
        }

        static async Task Main(string[] args)
        {
            var urls = new[] {
                "https://api.github.com/search/repositories?q=tetris+language:assembly",
                "https://api.github.com/users/wk-j",
                "https://api.github.com/users/dotnet",
                "https://api.github.com/users/fsharp",
            };

            var tasks = urls.Select(Download);
            var jsons = await Task.WhenAll(tasks);

        }
    }
}
