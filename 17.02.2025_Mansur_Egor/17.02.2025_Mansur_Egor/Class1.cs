namespace _17._02._2025_Mansur_Egor;

public class Class1
{
    // Методы для работы с int
    public static int Add(int a, int b) => a + b;

    public static int Subtract(int a, int b) => a - b;

    public static int Multiply(int a, int b) => a * b;

    public static double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль невозможно.");
        return (double)a / b;
    }

    // Методы для работы с double
    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;

    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль невозможно.");
        return a / b;
    }

    // Метод округления числа
    public static double RoundNumber(double value) => Math.Round(value);

    // Метод для преобразования строки в int
    public static int ParseInteger(string input)
    {
        if (!int.TryParse(input, out int result))
            throw new ArgumentException("Некорректные входные данные.");
        return result;
    }

    // Асинхронный метод для возврата результата с задержкой
    public static async Task<int> GetDelayedResultAsync(int value)
    {
        await Task.Delay(1000); // Искусственная задержка
        return value;
    }
}
