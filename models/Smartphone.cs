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
      Number = Tools.GenerateCellNumber();
    }

    // TODO: encapsulate string numberToCall
    public void Call()
    { 
      Console.WriteLine("Type the number: ");
      string numberCall = Console.ReadLine();
      Console.WriteLine($"Calling to {numberCall}...");
    }

    public void ReceiveCall()
    { 
      string receiveNumber = Tools.GenerateCellNumber();
      Console.WriteLine($"Receiving call {receiveNumber}...");
    }

    public abstract void InstallApp(string appName);
  }