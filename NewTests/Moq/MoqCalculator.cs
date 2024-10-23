namespace NewTests.Moq;

public class MoqCalculator
{
    public virtual int Multiply(int number1, int number2)
    {
        throw new NotImplementedException();
    }

    public int Pow2(int number)
    {
        return Multiply(number, number);
    }
}
