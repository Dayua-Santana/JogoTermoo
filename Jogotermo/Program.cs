using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        ExibirCabecalho();
        string[] palavras = ["TESTE", "TRENS", "CASAS", "FOGAO", "MELAO", "UMBOS"];
        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);
        string palavraAleatoria = palavras[indiceAleatorio];

        int tentativas = 0;
        bool acertou = false;

        while (tentativas < 6 && !acertou)
        {
            Console.Write($"\nTentativa {tentativas + 1} /6: ");
            string? chuteRaw = Console.ReadLine();


            string chute = "";
            if (chuteRaw == null || chuteRaw == "")
            {
                chute = "AAAAA";
            }
            else
            {

                for (int i = 0; i < chuteRaw.Length && i < 5; i++)
                {
                    chute += char.ToUpper(chuteRaw[i]);
                }

                while (chute.Length < 5)
                {
                    chute += 'A';
                }
            }

            string resultado = "";
            for (int indice = 0; indice < 5; indice++)
            {
                char letraChute = chute[indice];
                char letraCorreta = palavraAleatoria[indice];

                if (letraChute == letraCorreta)
                    resultado += "🟩";
                else if (palavraAleatoria.Contains(letraChute))
                    resultado += "🟨";
                else
                    resultado += "🔴";
            }
            Console.WriteLine($"{chute} --> {resultado}");
            tentativas++;
            acertou = (resultado == "🟩🟩🟩🟩🟩");

            if (acertou)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"🎉VOCÊ GANHOU! A palavra era {palavraAleatoria}");
                Console.WriteLine("--------------------------------------------");
                Console.ReadLine();
                return;
            }
        }

        if (!acertou)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"💀GAME OVER! A palavra era {palavraAleatoria}");
            Console.WriteLine("-----------------------------------------------");
            Console.ReadLine();
        }


    }

    static void ExibirCabecalho()
    {
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("🔥 JOGO DO TERMO 🔥");
        Console.WriteLine("🟩 = Correta | 🟨 = Existe | 🔴 = Não existe");
        Console.WriteLine("---------------------------------------------------");
    }

}
