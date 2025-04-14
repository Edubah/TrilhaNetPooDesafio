using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "121314", modelo: "NK01", imei: "1588789663", memoria: 90);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "151617", modelo: "IP01", imei: "1588789663", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

