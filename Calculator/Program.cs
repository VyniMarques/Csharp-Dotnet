using System.Runtime.InteropServices;

namespace Calculator;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("==== Calculadora Simples ====");

        bool running = true;
        while (running)
        {

            //double number1 = Convert.ToDouble(Console.ReadLine());
            //double number2 = Convert.ToDouble(Console.ReadLine());
            double number1;
            double number2;

            // Entrando Com Valores
            Console.WriteLine("Entre com o primeiro valor");
            while (!double.TryParse(Console.ReadLine(), out number1)) // Garantindo que é um valor numerico
            {
                Console.WriteLine("Entrada inválida! Ela deve ser um número!");
            }
            Console.WriteLine("Entre com o segundo valor");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Entrada inválida! Ela deve ser um número!");
            }


            // Entrando Com a operação
            Console.WriteLine("Qual operação gostaria de realizar?");
            Console.WriteLine(@"
            ========================
                1 - Adição (+)
                2 - Subtração (-)
                3 - Multiplicação (*)
                4 - Divisão (/)
                5 - Sair
            ========================
            ");

            //int op = Convert.ToInt32(Console.ReadLine());
            int op;
            while (!int.TryParse(Console.ReadLine(), out op))
            {
                Console.WriteLine("Opção inválida!");
            }


            double result = 0;

            if (op == 1)
            {
                result = number1 + number2;
            }
            else if (op == 2)
            {
                result = number1 - number2;
            }
            else if (op == 3)
            {
                result = number1 * number2;
            }
            else if (op == 4)
            {
                result = number1 / number2;
            }
            else
            {
                Console.WriteLine("Fim do Programa!");
                break;
            }
            Console.WriteLine("Resultado =  " + result + "\n");

            // Continuando no loop
            Console.WriteLine("Deseja continuar? (s/n)");
            string cont = Console.ReadLine() ?? ""; // Se retornar nulo recebe ""

            if (cont.Equals("s", StringComparison.CurrentCultureIgnoreCase)) // Compara String e ignora minusculo/maisculo
            {
                running = true;
            }
            else //if (cont.Equals("n", StringComparison.CurrentCultureIgnoreCase))
            {
                running = false;
            }
        }
    }
}