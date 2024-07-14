using System.Reflection;

var versionString = Assembly.GetEntryAssembly()?
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
    .InformationalVersion
    .ToString();

Console.WriteLine($"Hello, this is version {versionString}!");
