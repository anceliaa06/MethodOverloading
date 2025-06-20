namespace MethodOverloading
{
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Add(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Invalid Input");
                return 0;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("ADDING TWO INTEGERS: 5+10");
            Console.WriteLine($"RESULT: {calculator.Add(5,10)}\n");

            Console.WriteLine("ADDING TWO DOUBLES: 3.5 + 4.7");
            Console.WriteLine($"RESULT:  {calculator.Add(3.5, 4.7)}\n");

            Console.WriteLine("Adding array of integers: 1 + 2 + 3 + 4 + 5");
            Console.WriteLine($"Result: {calculator.Add(new int[] { 1, 2, 3, 4, 5 })}\n");

            Console.WriteLine("Invalid input: array is null.");
            Console.WriteLine($"Result (should be 0): {calculator.Add(null)}\n");

            Console.WriteLine("Invalid input: array is empty.");
            Console.WriteLine($"Result (should be 0): {calculator.Add(new int[] { })}");


        }
    }
}
