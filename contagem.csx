#!/usr/bin/env dotnet-script
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine($"{i}\n");
    System.Threading.Thread.Sleep(1000);
}
Console.WriteLine("Fogo!")
