using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        ExibirCabecalho();
        string[] palavras = ["TESTE", "TRENS", "CASAS", "FOGAO", "MELAO", "UMBOS"];
        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);
        return palavras[indiceAleatorio];

    }

    static void ExibirCabecalho()
    {
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("🔥 JOGO DO TERMO 🔥");
        Console.WriteLine("🟩 = Correta | 🟨 = Existe | 🔴 = Não existe");
        Console.WriteLine("---------------------------------------------------");
    }

}
