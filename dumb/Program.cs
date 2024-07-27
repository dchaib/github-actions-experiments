using System.Reflection;

var assembly = Assembly.GetEntryAssembly()!;
var version = assembly.GetName().Version;
var assemblyVersion = assembly.GetCustomAttribute<AssemblyVersionAttribute>()?.Version;
var assemblyFileVersion = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
var assemblyInformationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

Console.WriteLine($"Welcome to dumb!");
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine($"Version:                        {version}");
Console.WriteLine($"Assembly version:               {assemblyVersion}");
Console.WriteLine($"Assembly file version:          {assemblyFileVersion}");
Console.WriteLine($"Assembly informational version: {assemblyInformationalVersion}");
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine($"Time is {DateTime.Now}!");
