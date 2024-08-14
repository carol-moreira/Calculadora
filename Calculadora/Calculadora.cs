using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Calculadora
    {
        private Stack<double> resultados;

        public Calculadora()
        {
            resultados = new Stack<double>();
        }

        public void calcular(Operacoes operacao)
        {
            switch (operacao.operador)
            {
                case '+':
                    operacao.resultado = operacao.valorA + operacao.valorB;
                    break;
                case '-':
                    operacao.resultado = operacao.valorA - operacao.valorB;
                    break;
                case '*':
                    operacao.resultado = operacao.valorA * operacao.valorB;
                    break;
                case '/':
                    if (operacao.valorB != 0)
                    {
                        operacao.resultado = operacao.valorA / operacao.valorB;
                    }
                    else
                    {
                        throw new DivideByZeroException("Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    throw new InvalidOperationException("Operador inválido.");
            }

            // Armazenar o resultado na pilha
            resultados.Push(operacao.resultado);

            // Imprimir a operação e o resultado
            Console.WriteLine($"Operação: {operacao.valorA} {operacao.operador} {operacao.valorB}");
            Console.WriteLine("Resultado:");
            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}