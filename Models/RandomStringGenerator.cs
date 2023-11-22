using System;

public partial class RandomStringGenerator
{
  private static Random random = new Random();

  public static string GenerateRandomString(int length)
  {
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    char[] randomString = new char[length];

    for (int i = 0; i < length; i++)
    {
      randomString[i] = chars[random.Next(chars.Length)];
    }

    return new string(randomString);
  }
}