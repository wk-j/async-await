async Task<string> SomeAsync() {
    string a = null;
    a.ToString();
    return await Task.FromResult("Hello");
}

var rs = SomeAsync().GetAwaiter().GetResult();
Console.WriteLine(rs);