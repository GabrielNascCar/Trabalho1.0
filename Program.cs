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
            exibirDias();
        }

        static void exibirDias() {
            string[] diasArray = {"Segunda", "Terça","Quarta","Quita", "Sexta","Sábado", "Domingo"};

            foreach(string dia in diasArray) {
                Console.WriteLine($"Dia : {dia}");
                Thread.Sleep(1500);
            }

        }

    }
}