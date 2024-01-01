using Models.Phones;

Iphone phone = new Iphone(5);
phone.InstallApp("Good", 0.5);
phone.InstallApp("music", 4.5);
phone.ListApps();
Console.WriteLine(phone.AvailableMemory);
phone.UninstallApp("music", 4.5);
Console.WriteLine(phone.AvailableMemory);
phone.InstallApp("Discord", 2);
Console.WriteLine(phone.AvailableMemory);
phone.UninstallApp("Discord", 2);
Console.WriteLine(phone.AvailableMemory);