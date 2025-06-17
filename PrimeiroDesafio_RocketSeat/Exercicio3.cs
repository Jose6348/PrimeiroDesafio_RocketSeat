namespace PrimeiroDesafio_RocketSeat
{
    public class Exercicio3
    {

        public static void OperacoesMatematicas()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double soma = num1 + num2;
            double subtracao = num1 - num2;
            double multiplicacao = num1 * num2;
            double divisao = num1 / num2;
            double media = (num1 + num2) / 2;
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");
            Console.WriteLine($"Média: {media}");
        }
    }
}
