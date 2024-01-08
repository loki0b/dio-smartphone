using Models.Apps;

namespace Models.Phones
{
  public abstract class Smartphone
  { 
    private string _number;
    private string _imei;
    private string _model;
    private double _memory;
    private double _availableMemory;
    readonly protected Dictionary<string ,PhoneApp> _installedApps = new Dictionary<string, PhoneApp>();

    public Smartphone(double memory)
    {
      Memory = memory;
      Imei = Tools.GenerateImei();
      AvailableMemory = Memory;
    }

    public string Imei 
    { 
      get => _imei; 
      
      set => _imei = value;
    }
    protected double Memory 
    { 
      get => _memory;

      set => _memory = value;
    }
    public double AvailableMemory 
    { 
      get => _availableMemory;
      
      set 
      {
        if (value > Memory || value < 0) throw new Exception();

        _availableMemory = value;
      }
    }
    protected string Model 
    { 
      get => _model;

      set => _model = value;
    }
    public string Number 
    { 
      get => _number;

      set => _number = value;
    }
    
    public void GenerateNumber()
    { 
      Number = Tools.GenerateCellNumber();
    }

    public void Call()
    { 
      Console.WriteLine("Type the number: ");
      string numberCall = Console.ReadLine();
      Console.WriteLine($"Calling to {numberCall}...");
    }

    public void RecieveCall()
    { 
      string recieveNumber = Tools.GenerateCellNumber();
      Console.WriteLine($"Recieving call {recieveNumber}...");
    }

    public abstract void InstallApp(string appName, double size);

    public void UninstallApp(string appName)
    { 
      appName = appName.ToLower();
      try
      { 
        Console.WriteLine($"Uninstalling {_installedApps[appName].AppName}");
        ModifyAvailableMemory(true, _installedApps[appName].Size);
        _installedApps.Remove(appName.ToLower());
        Console.WriteLine($"{appName.ToLower()} Uninstalled Successfuly");
      }
      catch (KeyNotFoundException)
      {
        Console.WriteLine("App não encontrado.");
      }
    }

    public void ListApps() 
    {
      foreach (var app in _installedApps)
      {
        Console.WriteLine(app.Value.AppName);
      }
    }
    protected void ModifyAvailableMemory(bool option, double size)
    { 
      // Add available memory if true otherwise remove available memory
      if (option)
      {
        _availableMemory += size;
      }
      else
      {
        _availableMemory -= size;
      }
    }
  }
}