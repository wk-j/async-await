import fetch from "node-fetch"

async function start() {
    const [wk, dotnet] = await Promise.all([
        fetch("https://api.github.com/users/github"),
        fetch("https://api.github.com/users/dotnet")
    ]);
    return [wk, dotnet]
}

(async function () {
    var [wk, dotnet] = await start();
    console.log(await wk.json());
})();