namespace Models
{
  class Nokia : Smartphone
  {
    public Nokia(int memory) : base(memory)
    {
      Model = "Nokia";
    }

    override public void InstallApp(string appName)
    {
      Console.WriteLine($"Installing {appName}...");
    }
  }
}
