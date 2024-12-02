namespace HashingTest;

class Program
{
    static void Main(string[] args)
    {
      Hashing hashing = new Hashing();
      string password = "password123";
      string hash = hashing.Hash(password);
      Console.WriteLine(hash);
    }
}
