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

            Console.WriteLine("Você deseja ver as informações de forma simuntânea?");
            Console.WriteLine("Se sim, digite 1");
            Console.WriteLine("Se não, digite 2");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool verdadeiro = true;

            while (verdadeiro)
            {
                if (numero == 1)
                {
                    Parallel.Invoke(
                    new Action (nomeFuncionario),
                    new Action(salarioFuncionario),
                    new Action(idadeFuncionario)
                    );
                    verdadeiro = false;
                }else if (numero == 2)
                {
                    nomeFuncionario();
                    salarioFuncionario();
                    idadeFuncionario();
                    verdadeiro = false;
                }else 
                {
                    Console.WriteLine("Você digitou um número invalido! Tente novamente.");
                    numero = Convert.ToInt32(Console.ReadLine());
                }

            }
           

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