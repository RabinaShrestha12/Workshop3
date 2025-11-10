namespace Task6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExceptionExamples obj = new ExceptionExamples();

            Console.WriteLine("Task 6.1");
            obj.NumberConversion();

            Console.WriteLine(" Task 6.2 ");
            obj.PasswordCheck();
        }
    }

    public class ExceptionExamples
    {
        // Program to handle invalid number input
        public void NumberConversion()
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        // Program to check password length and throw exception if invalid
        public void PasswordCheck()
        {
            try
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
