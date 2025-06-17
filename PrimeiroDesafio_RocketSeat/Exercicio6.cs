using System.Globalization;

namespace PrimeiroDesafio_RocketSeat
{
    public class Exercicio6
    {
        public static void VerificarHora()
        {
            // Define a cultura para "Português do Brasil" para garantir que os nomes 
            // (dia da semana, mês) apareçam corretamente em português.
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            // Captura a data e a hora atuais uma única vez
            DateTime dataAtual = DateTime.Now;

            Console.WriteLine("--- Exibindo a Data e Hora Atuais em Diferentes Formatos ---");
            Console.WriteLine();

            // 1. Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)
            // O especificador de formato "F" representa o padrão de data e hora longas.
            Console.WriteLine("1. Formato completo:");
            Console.WriteLine(dataAtual.ToString("F"));
            Console.WriteLine();

            // 2. Apenas a data no formato "dd/MM/yyyy"
            // O especificador "d" representa o padrão de data curta.
            Console.WriteLine("2. Apenas a data (dd/MM/yyyy):");
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
            Console.WriteLine();

            // 3. Apenas a hora no formato de 24 horas
            // O especificador "T" representa o padrão de hora longa (24h).
            Console.WriteLine("3. Apenas a hora (formato 24h):");
            Console.WriteLine(dataAtual.ToString("HH:mm:ss"));
            Console.WriteLine();

            // 4. A data com o mês por extenso
            // O especificador "D" representa o padrão de data longa (com mês por extenso).
            Console.WriteLine("4. Data com mês por extenso:");
            Console.WriteLine(dataAtual.ToString("D"));
            Console.WriteLine();
        }
    }
}
