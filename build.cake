Task("Run").Does(() => {
  StartProcess("dotnet", new ProcessSettings {
      Arguments = "run --project CSharp/Deconstruct/Deconstruct.csproj --configuration Release"
  });  
});

var target = Argument("target", "default");
RunTarget(target);