using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            // Adiciona operações à fila
            // E mudei o tipo de int para long para suportar valores maiores que o limite do int
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); // Implemente o cálculo de divisão

            Calculadora calculadora = new Calculadora();
            Stack<string> pilhaResultados = new Stack<string>(); // Alterado para armazenar expressões completas

            // Alterei a condição do loop para filaOperacoes.Count > 0 para evitar loop infinito
            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue(); // Mudei de Peek para Dequeue para processar e remover item da fila
                calculadora.calcular(operacao);
                pilhaResultados.Push($"{operacao.valorA} {operacao.operador} {operacao.valorB} = {operacao.resultado}"); // Armazena a expressão completa na pilha
                Console.WriteLine("{0} {1} {2} = {3}\n", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                // Imprimir lista de operações restantes após cada cálculo
                ImprimirListaOperacoes(filaOperacoes);
            }

            // Imprimir a pilha de resultados ao final
            ImprimirPilhaResultados(pilhaResultados);
        }

        static void ImprimirListaOperacoes(Queue<Operacoes> fila)
        {
            Console.WriteLine("Operações restantes na fila:");
            foreach (var operacao in fila)
            {
                Console.WriteLine("{0} {1} {2}", operacao.valorA, operacao.operador, operacao.valorB);
            }
            Console.WriteLine();
        }

        // Para mostrar a pilha de resultados no final
        static void ImprimirPilhaResultados(Stack<string> pilha)
        {
            Console.WriteLine("Resultados na pilha:");
            // Reverter a pilha para imprimir na ordem correta
            var pilhaTemp = new Stack<string>(pilha);
            foreach (var resultado in pilhaTemp)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}
