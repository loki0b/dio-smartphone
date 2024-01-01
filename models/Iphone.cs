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
