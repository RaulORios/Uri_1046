using System;

namespace Uri_1046
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int hora_inicio = int.Parse(valores[0]);
            int hora_fim = int.Parse(valores[1]);

            int duracao;

            if (hora_inicio < hora_fim)
            {
                duracao = hora_fim - hora_inicio;
            }
            else
            {
                duracao = 24 - hora_inicio + hora_fim;
            }
                                    
            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            
        }
    }
}
