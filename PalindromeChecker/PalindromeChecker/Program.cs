using System;

namespace PalindromeChecker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Ingrese una cadena para verificar si es un palíndromo:");
            string input = Console.ReadLine();

            try
            {
                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("La cadena no debe estar vacía.");

                bool resultado = PalindromeValidator.EsPalindromo(input);
                Console.WriteLine($" Resultado: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
            }
        }
    }
}
