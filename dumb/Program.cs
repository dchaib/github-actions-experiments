using System.Reflection;

var versionString = Assembly.GetEntryAssembly()?
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
    .InformationalVersion
    .ToString();

Console.WriteLine($"Hello, this is version {versionString}!");
Console.WriteLine($"Time is {DateTime.Now}!");
Console.WriteLine($"1 + 1 = 2");
Console.WriteLine($"2 + 1 = 3");
