using Models;

Iphone s1 = new Iphone(5);
Console.WriteLine(s1.Number);
Console.WriteLine(s1.Imei);
s1.Call();
s1.ReceiveCall();