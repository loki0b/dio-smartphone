using Models.Apps;

namespace Models.Phones
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
      PhoneApp app = new PhoneApp(appName, DateTime.Now);
      AddApp(app);
      Console.WriteLine($"{appName} Installed Successfully");
    }
  }
}
