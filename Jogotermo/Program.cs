using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        ExibirCabecalho();

    }

    static void ExibirCabecalho()
    {
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("🔥 JOGO DO TERMO 🔥");
        Console.WriteLine("🟩 = Correta | 🟨 = Existe | 🔴 = Não existe");
        Console.WriteLine("---------------------------------------------------");
    }

}
