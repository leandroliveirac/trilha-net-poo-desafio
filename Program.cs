using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"199999999",modelo:"modelo 1",emei:"99999999",memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"188888888",modelo:"modelo 2",emei:"88888888",memoria:64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");