using Models.Apps;

namespace Models.Phones
{
  class Iphone : Smartphone
  { 
    public Iphone(int memory) : base(memory)
    {
      Model = "Iphone"; 
    }

    override public void InstallApp(string appName, double size)
    { 
      if (this.AvailableMemory > size)
      {
        PhoneApp newApp = new PhoneApp(appName.ToLower(), size);  
        Console.WriteLine($"Installing {newApp.AppName}...");
        _installedApps.Add(newApp.AppName, newApp);
        ModifyAvailableMemory(false, newApp.Size);
        Console.WriteLine($"{appName} Installed Successfully");
      } 
      else
      {
        Console.WriteLine($"{appName} not Installed\nNot Enough Space");
      } 
    }
  }
}
