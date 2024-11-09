using System;

/*Este projeto é uma calculadora básica desenvolvida em C# para servir de exemplo em uma oficina de GitHub voltada para alunos do ensino médio.
 A calculadora realiza operações aritméticas simples, como adição, subtração, multiplicação e divisão,
 e foi pensada como uma introdução prática ao uso de GitHub para controle de versão e colaboração em projetos de código.*/

namespace CalculadoraGitHUb;
class Project
{
    static void Main(string[] args)
    {
        //Declaração de variáveis

        int num1 = 0, num2 = 0, operador = 0, resultado = 0;

        //Entrada de valores 

        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine();

        Console.Write("Qual tipo de operação você gostaria de realizar? ");
        operador = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Digite o primeiro número:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //Processamento

        switch (operador)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                resultado = num1 / num2;
                break;

        }

        //Saída

        Console.WriteLine($"O resultado da operação desejada é: {resultado}");
    }
}