async Task<string> SomeAsync() {
    string a = null;
    a.ToString();
    throw new ArgumentNullException("555");
    return await Task.FromResult("Hello");
}

var rs = SomeAsync().Result;
Console.WriteLine(rs);