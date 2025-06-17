namespace PrimeiroDesafio_RocketSeat
{
    public class Exercicio4
    {
        public static void ContadorDeCaracteres()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            int contador = 0;
            foreach (char c in frase)
            {
                if (char.IsLetter(c))
                {
                    contador++;
                }
            }
            Console.WriteLine($"A quantidade de letras na frase é: {contador}");
        }
    }
}
