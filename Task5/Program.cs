namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoopsExample obj = new LoopsExample();
            obj.SumUsingForLoop();
            obj.PrintUsingWhileLoop();
            obj.SumArrayUsingForEach();
        }
    }

    public class LoopsExample
    {
        // For Loop – Sum from 1 to N
        public void SumUsingForLoop()
        {
            Console.Write("Enter a number (N): ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum from 1 to {N} = {sum}");
        }

        // While Loop – Skip multiples of 4, stop at 15
        public void PrintUsingWhileLoop()
        {
            int i = 1;

            Console.WriteLine("Printing numbers from 1 to 20 (skip multiples of 4, stop at 15):");
            while (i <= 20)
            {
                if (i == 15)
                    break; // Stop when number is 15

                if (i % 4 == 0)
                {
                    i++;
                    continue; // Skip multiples of 4
                }

                Console.WriteLine(i);
                i++;
            }
        }

        // Foreach Loop – Sum of array elements
        public void SumArrayUsingForEach()
        {
            int[] numbers = { 3, 7, 2, 8, 5 };
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"Sum of array elements = {sum}");
        }
    }
}
