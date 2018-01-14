
using System.Net;

var client = new WebClient();
client.DownloadStringAsync(new Uri("https://google.com"));