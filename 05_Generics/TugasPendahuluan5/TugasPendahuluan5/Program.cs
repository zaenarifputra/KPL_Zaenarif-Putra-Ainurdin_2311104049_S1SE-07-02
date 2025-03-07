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
using System;

class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yg tersimpan adalah : {data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> myData = new DataGeneric<string>("2311104049");
        myData.PrintData();
        Console.ReadLine();
    }
}