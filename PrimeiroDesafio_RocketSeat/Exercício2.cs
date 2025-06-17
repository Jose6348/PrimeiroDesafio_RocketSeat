namespace PrimeiroDesafio_RocketSeat
{
    public class Exercício2
    {
        public static void NomeESobrenome()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}");
        }
    }
}
