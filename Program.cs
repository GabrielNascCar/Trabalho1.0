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
                new Action (nomeFuncionario),
                new Action(salarioFuncionario),
                new Action(idadeFuncionario)
            );

            Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
            Console.ReadLine();
            
        }

        static void nomeFuncionario() {
            string[] nomesArray = {"Gabriel", "Arthur", "Fernando", "Thaynara", "Maria", "José", "Claudio"};

            foreach(string nome in nomesArray) {
                Console.WriteLine($"Nome : {nome}");
                Thread.Sleep(1500);
            }

        }

        static void salarioFuncionario()
        {
            double[] salarioArray = { 3000, 2500, 2800, 3500, 4000, 3750, 6000};

            foreach (double salario in salarioArray)
            {
                Console.WriteLine($"Salario : {salario}");
                Thread.Sleep(1500);
            }
        }

        static void idadeFuncionario(){
            int[] idadeArray = {18, 20, 22, 18, 27, 30, 28};

            foreach(int idade in idadeArray)
            {
                Console.WriteLine($"Idade : {idade}");
                Thread.Sleep(1500);
            }

        }

    }
}