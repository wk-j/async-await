import axios from "axios";

let urls = [
    "https://api.github.com/search/repositories?q=tetris+language:assembly",
    "https://api.github.com/users/wk-j",
    "https://api.github.com/users/dotnet",
    "https://api.github.com/users/fsharp"
]

async function download(url) {
    console.log(`download - ${url}`);
    var rs = await axios.get(url);
    console.log(`complete - ${url}`);
    return rs;
}

async function start() {
    let tasks = urls.map(download);
    Promise.all(tasks);
}

start();