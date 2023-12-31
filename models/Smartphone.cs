public abstract class Smartphone
  { 
    private string _number;
    private string _imei;
    private string _model;
    private int _memory;

    public Smartphone(int memory)
    {
      Memory = memory;
      Imei = Tools.GenerateImei(); 
    }

    public string Imei 
    { 
      get => _imei; 
      
      set => _imei = value;
    }
    protected int Memory 
    { 
      get => _memory;

      set => _memory = value;
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
      Number = "+55819" + Tools.GenerateCellNumber();
    }

    public void Call()
    {
      Console.WriteLine($"{Number} Calling...");
    }

    public void ReceiveCall()
    {
      Console.WriteLine($"{Number} Receiving call...");
    }

    public abstract void InstallApp(string appName);
  }