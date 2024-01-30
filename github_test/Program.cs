// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double sum = firstNumber + secondNumber;
        Console.WriteLine("Результат сложения " + sum);
    }
}