namespace Fibonacci
{
    public class FibonacciService
    {
        public static void GenerateNumbers()
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.ChooseGenerationType();
            fibonacci.ChooseValue();
        }
    }
}
