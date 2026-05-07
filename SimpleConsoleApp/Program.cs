using System;

namespace SimpleConsoleApp;

internal static class Program
{
    private static void Main(string[] args)
    {
        var name = args.Length > 0 ? string.Join(' ', args) : "World";
        Console.WriteLine($"Hello, {name}!");
    }
}
