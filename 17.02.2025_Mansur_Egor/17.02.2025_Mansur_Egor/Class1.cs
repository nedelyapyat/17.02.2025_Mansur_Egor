namespace _17._02._2025_Mansur_Egor;

public class Class1
{
    internal static double Add(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    internal static double Divide(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    internal static double Multiply(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    internal static double Subtract(int v1, int v2)
    {
        throw new NotImplementedException();
    }

public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;

    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль невозможно.");
        return a / b;
    }

    public static int ParseInteger(string input)
    {
        if (!int.TryParse(input, out int result))
            throw new ArgumentException("Некорректные входные данные.");
        return result;
    }


}
