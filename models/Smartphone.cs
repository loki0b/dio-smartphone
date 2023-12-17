namespace Models
{
  public abstract class Smartphone
  {
    public Smartphone(string number, string imei, int memory) 
    {
      Number = number;
      Imei = imei;
      Memory = memory;
    }
    public string Number { get; set; }
    protected string Imei { get; set; }
    protected string Model { get; set; }
    protected int Memory { get; set; }

    public void Call()
    {
      Console.WriteLine("Calling...");
    }
    public void ReceiveCall()
    {
      Console.WriteLine("Receiving call...");
    }

    public abstract void InstallApp(string appName);
  }
}