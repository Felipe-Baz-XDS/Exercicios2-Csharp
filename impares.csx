#!/usr/bin/env dotnet-script

Console.WriteLine("Digite um numero:\n");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Os numeros impares entre 0 e {num} são:");
for (int i = 1; i < num; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine($"{i}");
    }
}
