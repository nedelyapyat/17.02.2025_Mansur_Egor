using _17._02._2025_Mansur_Egor;
using Xunit;

namespace test1;

public class UnitTest1
{
    // Тесты для работы с int
    [Fact]
    public void Add_Int_ReturnsCorrectSum()
    {
        int result = Class1.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_Int_ReturnsCorrectDifference()
    {
        int result = Class1.Subtract(10, 5);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_Int_ReturnsCorrectProduct()
    {
        int result = Class1.Multiply(3, 4);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Divide_Int_ReturnsCorrectQuotient()
    {
        double result = Class1.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_Int_ThrowsException_OnZeroDivider()
    {
        Assert.Throws<DivideByZeroException>(() => Class1.Divide(10, 0));
    }

    // Тесты для работы с double
    [Fact]
    public void Add_Double_ReturnsCorrectSum()
    {
        double result = Class1.Add(2.5, 3.5);
        Assert.Equal(6.0, result);
    }

    [Fact]
    public void Subtract_Double_ReturnsCorrectDifference()
    {
        double result = Class1.Subtract(5.5, 2.5);
        Assert.Equal(3.0, result);
    }

    [Fact]
    public void Multiply_Double_ReturnsCorrectProduct()
    {
        double result = Class1.Multiply(2.5, 4.0);
        Assert.Equal(10.0, result);
    }

    [Fact]
    public void Divide_Double_ReturnsCorrectQuotient()
    {
        double result = Class1.Divide(10.5, 2.5);
        Assert.Equal(4.2, result, 1); // Последний аргумент — точность
    }

    [Fact]
    public void Divide_Double_ThrowsException_OnZeroDivider()
    {
        Assert.Throws<DivideByZeroException>(() => Class1.Divide(10.5, 0));
    }

    // Тесты для ParseInteger
    [Fact]
    public void ParseInteger_ReturnsCorrectValue()
    {
        int result = Class1.ParseInteger("123");
        Assert.Equal(123, result);
    }

    [Fact]
    public void ParseInteger_ThrowsException_OnInvalidInput()
    {
        Assert.Throws<ArgumentException>(() => Class1.ParseInteger("abc"));
    }

    // Тесты для RoundNumber
    [Theory]
    [InlineData(2.5, 3)]
    [InlineData(2.4, 2)]
    [InlineData(-2.5, -2)]
    [InlineData(-2.6, -3)]
    public void RoundNumber_ReturnsExpectedValue(double input, double expected)
    {
        double result = Class1.RoundNumber(input);
        Assert.Equal(expected, result);
    }

    // Асинхронный метод
    [Fact]
    public async Task GetDelayedResultAsync_ReturnsCorrectValue()
    {
        int result = await Class1.GetDelayedResultAsync(10);
        Assert.Equal(10, result);
    }

    [Fact]
    public async Task GetDelayedResultAsync_WorksWithNegativeValue()
    {
        int result = await Class1.GetDelayedResultAsync(-10);
        Assert.Equal(-10, result);
    }
}
