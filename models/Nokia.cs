using Models.Apps;

namespace Models.Phones
{
  class Nokia : Smartphone
  {
    public Nokia(double memory) : base(memory)
    {
      Model = "Nokia";
    }

    override public void InstallApp(string appName, double size)
    {
      Console.WriteLine($"Installing {appName}...");
      if (this.AvailableMemory > size)
      {
        PhoneApp app = new PhoneApp(appName, size);
        AddApp(app);
        Console.WriteLine($"{appName} Installed Successfully");
      }
      else
      {
        Console.WriteLine($"{appName} not Installed\nNot Enough Space");
      }   
    }
  }
}
