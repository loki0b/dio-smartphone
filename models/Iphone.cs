namespace Models
{
  class Iphone : Smartphone
  {
    public Iphone(string number, string imei, int memory) : base(number, imei, memory) 
    {
      this.Model = "Iphone";
    }
    override public void InstallApp(string appName) 
    {
      Console.WriteLine($"Installing {appName}...");
    }
  }
}