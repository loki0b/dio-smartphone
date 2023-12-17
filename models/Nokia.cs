namespace Models
{
  class Nokia : Smartphone
  {
    public Nokia(string number, string imei, int memory) : base(number, imei, memory) 
    {
      this.Model = "Nokia";
    }
    override public void InstallApp(string appName) 
    {
      Console.WriteLine($"Installing {appName}...");
    }
  }
}