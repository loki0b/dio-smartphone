using Models;

Iphone iphone1 = new Iphone("123", "456", 4);
Nokia nokia1 = new Nokia("789", "987", 6);

iphone1.Call();
iphone1.ReceiveCall();
iphone1.InstallApp("Goodnotes 6");

nokia1.Call();
nokia1.ReceiveCall();
nokia1.InstallApp("Spotify");