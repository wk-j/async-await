import axios from "axios";

let urls = [
    "https://api.github.com/search/repositories?q=tetris+language:assembly",
    "https://api.github.com/users/wk-j",
    "https://api.github.com/users/dotnet",
    "https://api.github.com/users/fsharp"
]

async function download(url) {
    console.log(`download - ${url}`);
    var json = await axios.get(url);

    console.log(`complete - ${url}`);
    return json;
}

async function start() {
    let tasks = urls.map(download);
    await Promise.all(tasks);
}

start();