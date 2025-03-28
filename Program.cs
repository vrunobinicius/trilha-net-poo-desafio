using DesafioPOO.Models;

// TO-DO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 64);
Console.WriteLine("Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nIphone:");
Iphone iphone = new Iphone("987654321", "Iphone 16", "987654321", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");