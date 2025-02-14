using System.Runtime.InteropServices;

namespace Calculator;

public class Program
{

    public static void Main()
    {


        Console.WriteLine("Entre com dois valores");
        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual operação gostaria de realizar?");
        Console.WriteLine(@"
        1 - Adição
        2 - Subtração
        3 - Multiplicação
        4 - Divisão
        5 - Sair
        ");
        int op = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Fim do Programa");
        }
        Console.WriteLine("Resultado =  " + result);

    }


}