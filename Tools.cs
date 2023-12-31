public static class Tools
{
  public static string GenerateCellNumber()
  {
    Random rnd = new Random();
    string cellNumber = "+55819" + rnd.Next(87654321, 99999999).ToString();

    return cellNumber;
  }

  public static string GenerateImei()
  {
    Random rnd = new Random();
    string cellImei = rnd.Next(1234567, 9999999).ToString() + rnd.Next(12345678, 99999999).ToString();

    return cellImei;

  }
}