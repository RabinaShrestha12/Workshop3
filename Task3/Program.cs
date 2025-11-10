class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 13)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("Teenager");
        }
        else // age >= 20
        {
            Console.WriteLine("Adult");
        }

        // Keep console open
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}