using System;

namespace CriançaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            string educado;

            //<---Inicio(Digite)--->//
            Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a lição de casa: ");
            educado = Console.ReadLine();
            Console.Write("\n");
            //<---Fim(Digite)--->//

            //<---Inicio(Substituíção)--->//
            Console.WriteLine("Eu sou uma criança educada. No seu lugar diria: ");
            Console.WriteLine($"{educado}"
                .Replace("chato", "#@$%*!&")
                .Replace("chata", "#@$%*!&")

                .Replace("bobo", "#@$%*!&")
                .Replace("boba", "#@$%*!&")

                .Replace("feio", "#@$%*!&")
                .Replace("feia", "#@$%*!&")

                .Replace("tonto", "#@$%*!&")
                .Replace("tonta", "#@$%*!&")

                .Replace("paspalho", "#@$%*!&")
                .Replace("paspalha", "#@$%*!&")

                .Replace("pentelho", "#@$%*!&")
                .Replace("pentelha", "#@$%*!&")

                .Replace("burro", "#@$%*!&")
                .Replace("burra", "#@$%*!&")

                .Replace("boboca", "#@$%*!&")
                .Replace("bocó", "#@$%*!&")

                .Replace("palerma", "#@$%*!&")
                .Replace("antã", "#@$%*!&")

                .Replace("panaca", "#@$%*!&")
                .Replace("besta", "#@$%*!&"));
            //<---Fim(Substituíção)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->//
        }
    }
}
