// Learn more about F# at http://fsharp.org

open System
open System.Net

let download (url: string) = 
    async {
        printfn "download - %s" url

        use client = new WebClient()
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.13; rv:58.0) Gecko/20100101 Firefox/58.0");
        let rs = client.DownloadString url

        printfn "complete - %s" url
        return rs
    }

[<EntryPoint>]
let main argv =
    let urls = 
        [ "https://api.github.com/search/repositories?q=tetris+language:assembly"
          "https://api.github.com/users/wk-j"
          "https://api.github.com/users/dotnet"
          "https://api.github.com/users/fsharp"
        ] |> List.map download

    let jsons = Async.Parallel urls |> Async.RunSynchronously
    0

