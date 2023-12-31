namespace Models
{
  class Iphone : Smartphone
  {
    public Iphone(int memory) : base(memory)
    {
      Model = "Iphone";
      GenerateNumber();
    }

    override public void InstallApp(string appName)
    {
      Console.WriteLine($"Installing {appName}...");
    }
  }
}
