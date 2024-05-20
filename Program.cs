using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("2345678", "A-113", "111111111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "8765432", modelo: "15", imei: "22222222222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");