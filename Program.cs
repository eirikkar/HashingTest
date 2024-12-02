namespace HashingTest;

class Program
{
    static void Main(string[] args)
    {
      Hashing hashing = new Hashing();
      string password = "password123";
      string hash = hashing.Hash(password);
      Console.WriteLine(hash);

      string password2 = "password123";
      string hash2 = hashing.HashWithoutSalt(password2);
      Console.WriteLine(hash2);

      string password3 = "password123";
      string hash3 = hashing.HashWithoutSalt(password3);
      Console.WriteLine(hash3);
      
      Console.WriteLine(hashing.Verify(passwordCheck(), hash));

    }
    static string passwordCheck()
    {
      Console.WriteLine("Enter password to check");
      string? input = Console.ReadLine();
      if (string.IsNullOrWhiteSpace(input))
      {
        Console.WriteLine("Please type something");
        passwordCheck();
      }
      return input;
        
    }
}
