namespace Task2;

public class NullOperations
{
          public void PerformNullChecks()
    {
        string username = null;
        Console.WriteLine(username == null ? "Username is not available" : username);
        Console.WriteLine(username ?? "Username is not available (checked using ??)");
        username ??= "abs ";
        Console.WriteLine("Updated username: " + username);
    }

    
}
