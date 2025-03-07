// See https://aka.ms/new-console-template for more information
using System;

class HaloGeneric
{
    public static void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo user {nama}!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric.SapaUser("Intan Payoo");
        Console.ReadLine();
    }
}