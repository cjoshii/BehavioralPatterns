namespace Strategy;

public interface ICalculate
{
    int Execute(int a, int b);
}

public class Add : ICalculate
{
    public int Execute(int a, int b) => a + b;
}

public class Substract : ICalculate
{
    public int Execute(int a, int b) => a - b;
}

public class Multiply : ICalculate
{
    public int Execute(int a, int b) => a * b;
}

public class Calculator
{
    private ICalculate? strategy;
    public void SetStrategy(ICalculate strategy)
    {
        this.strategy = strategy;
    }
    public int Execute(int a, int b)
    {
        if (strategy == null)
        {
            throw new InvalidOperationException("Strategy is not set.");
        }
        return strategy.Execute(a, b);
    }
}