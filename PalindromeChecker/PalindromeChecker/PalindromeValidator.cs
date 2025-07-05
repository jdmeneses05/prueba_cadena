using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    public static class PalindromeValidator
    {
        /// <summary>
        /// Verifica si una cadena es un palíndromo.
        /// Ignora espacios, puntuación y mayúsculas/minúsculas.
        /// </summary>
        /// <param name="texto">Texto a verificar</param>
        /// <returns>true si es palíndromo, false si no</returns>
        public static bool EsPalindromo(string texto)
        {
            if (texto == null)
                throw new ArgumentNullException(nameof(texto), "La cadena no puede ser nula.");

            // Remover todo excepto letras y números
            string limpio = Regex.Replace(texto, @"[^A-Za-z0-9]", "").ToLowerInvariant();

            if (string.IsNullOrWhiteSpace(limpio))
                throw new ArgumentException("La cadena no contiene caracteres válidos para evaluar.");

            int izquierda = 0;
            int derecha = limpio.Length - 1;

            while (izquierda < derecha)
            {
                if (limpio[izquierda] != limpio[derecha])
                    return false;
                izquierda++;
                derecha--;
            }

            return true;
        }

    }
}
