using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace trabalhoFaculdade {
    internal static class Program {

        static void Main() {
            Console.WriteLine("Precione ENTER para começar!");
            Console.ReadLine();

            Parallel.Invoke(
                new Action (exibirDias),
                new Action(Exibirmeses),
                new Action(ExibirCidades)
            );

            Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
            Console.ReadLine();
            
        }

        static void exibirDias() {
            string[] diasArray = {"Segunda", "Terça","Quarta","Quita", "Sexta","Sábado", "Domingo"};

            foreach(string dia in diasArray) {
                Console.WriteLine($"Dia : {dia}");
                Thread.Sleep(1500);
            }

        }

        static void Exibirmeses()
        {
            string[] messArray = { "Jan", "Fev", "Mar", "Abr", "Mai",
                                    "Jun", "Jul", "Ago", "Set", "Out",
                                    "Nov", "Dec"};

            foreach (string mes in messArray)
            {
                Console.WriteLine($"Mês : {mes}");
                Thread.Sleep(1200);
            }
        }

        static void ExibirCidades(){
            string[] cidadesArray = {"São Paulo", "Natal", "Rio de Janeiro", "Belo horizonte", "Brazilia", "Jaboatão"};

            foreach(string cidade in cidadesArray)
            {
                Console.WriteLine($"Cidade : {cidade}");
                Thread.Sleep(2000);
            }

        }

    }
}