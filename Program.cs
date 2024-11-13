using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"123456", modelo:"Modelo 123", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero:"654321", modelo:"Modelo XX", imei: "987654321", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
