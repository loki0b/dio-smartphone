namespace Models.Apps
{
  public class PhoneApp()
  {
    private string _appName;
    private DateTime _dateInstalled;

    public PhoneApp(string appName, DateTime dateInstalled) : this()
    {
      AppName = appName;
      DateInstalled = dateInstalled;
    }
    public string AppName 
    { 
      get => _appName;
      
      set => _appName = value; 
    }
    public DateTime DateInstalled
    { 
      get => _dateInstalled;
      
      set => _dateInstalled = value; 
    }
  }
}