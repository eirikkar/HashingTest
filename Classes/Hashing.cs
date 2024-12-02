using System.Security.Cryptography;
public class Hashing
{
  private int SaltSize = 16;
  private int HashSize = 32;
  private int Iterations = 100000;
  private static readonly HashAlgorithmName HashAlgorithm = HashAlgorithmName.SHA512;
  public string Hash(string password)
  {
    byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
    byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithm, HashSize);
    return $"{Convert.ToHexString(salt)}.{Convert.ToHexString(hash)}";
  }
  public string HashWithoutSalt(string password)
  {
    byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, new byte[0], Iterations, HashAlgorithm, HashSize);
    return Convert.ToHexString(hash);
  }
}
