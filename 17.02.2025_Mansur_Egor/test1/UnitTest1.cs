using _17._02._2025_Mansur_Egor;


namespace test1;

public class UnitTest1
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        // ��������� ��������
        double result = Class1.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        // ��������� ���������
        double result = Class1.Subtract(10, 5);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct()
    {
        // ��������� ���������
        double result = Class1.Multiply(3, 4);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Divide_ReturnsCorrectQuotient()
    {
        // ��������� �������
        double result = Class1.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ThrowsException_OnZeroDivider()
    {
        // ��������� ������ ���������� ��� ������� �� ����
        Assert.Throws<DivideByZeroException>(() => Class1.Divide(10, 0));
    }

    [Fact]
    public void ParseInteger_ThrowsException_OnInvalidInput()
    {
        Assert.Throws<ArgumentException>(() => Class1.ParseInteger("abc"));
    }

    public class ResourceTests : IDisposable
    {
        private string _filePath;

        public ResourceTests()
        {
            // �������������
            _filePath = "test.txt";
            File.WriteAllText(_filePath, "�������� ������");
        }

        public void Dispose()
        {
            // ������� ��������
            if (File.Exists(_filePath))
                File.Delete(_filePath);
        }

        [Fact]
        public void FileExists_ReturnsTrue()
        {
            Assert.True(File.Exists(_filePath));
        }
    }
}
