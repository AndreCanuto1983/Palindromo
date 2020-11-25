using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;

            do
            {
                var result = string.Empty;

                Console.WriteLine("\n=============Palíndromo=============\n");
                Console.WriteLine("Digite uma palavra: ");

                input = Console.ReadLine();

                if (input != string.Empty)
                {
                    for (int i = input.Length - 1; i > -1; i--)
                    {
                        result += input[i];
                    }

                    printExit(input == result ? true : false, input, result);
                }

            } while (input != string.Empty);
        }

        private static void printExit(bool palindromo, string input, string result)
        {
            Console.WriteLine("\n" + "A palavra " + input + (palindromo == true? " é" : " não é") + " Palíndromo");
            Console.WriteLine("\nEntrada = " + input);
            Console.WriteLine("Saída = " + result);
        }
    }
}