namespace PrimeiroDesafio_RocketSeat;

public class Exercicio5
{
    public static void VerificarPlaca()
    {
        Console.Write("Digite a placa do veículo (formato ABC1234): ");
        string placa = Console.ReadLine(); // Não precisa de ToUpper() imediatamente

        bool placaValida = false;

        // Verifica se a placa não é nula e tem exatamente 7 caracteres
        if (!string.IsNullOrEmpty(placa) && placa.Length == 7)
        {
            // Extrai as partes da placa
            string letras = placa.Substring(0, 3);
            string numeros = placa.Substring(3, 4);

            // Verifica se os 3 primeiros são letras E os 4 últimos são números
            if (letras.All(char.IsLetter) && numeros.All(char.IsDigit))
            {
                placaValida = true;
            }
        }

        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");
    }
}