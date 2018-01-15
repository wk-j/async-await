import fetch from "node-fetch"

async function start() {
    return await fetch("https://api.github.com/users/github")
}

(async function () {
    var data = await start().catch(err => {
        console.error("error");
        console.error(err);
    });

    if (data) {
        console.log(await data.json())
    }

})();