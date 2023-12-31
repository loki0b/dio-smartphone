using Models.Apps;

namespace Models.Phones
{
  class Iphone : Smartphone
  { 
    public Iphone(int memory) : base(memory)
    {
      Model = "Iphone"; 
    }

    override public void InstallApp(string appName)
    { 
      PhoneApp app = new PhoneApp(appName, DateTime.Now);
      Console.WriteLine($"Installing {app.AppName}...");
      AddApp(app);
      Console.WriteLine($"{appName} Installed Successfully");
    }
  }
}
