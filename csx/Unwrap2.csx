async Task<string> SomeAsync() {
    string a = null;
    a.ToString();
    throw new OutOfMemoryException("555");
    return await Task.FromResult("Hello");
}

var rs = await SomeAsync();
Console.WriteLine(rs);