namespace Models.Apps
{
  public class PhoneApp()
  {
    private string _appName;
    private double _size;

    public PhoneApp(string appName, double size) : this()
    {
      AppName = appName;
      Size = size;
    }
    public string AppName 
    { 
      get => _appName;
      
      set => _appName = value; 
    }
    public double Size
    { 
      get => _size;
      
      set
      {
        if (value > 0)
        {
          _size = value; 
        }

        throw new Exception();
      }
    }
  }
}