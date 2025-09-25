using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("99999999999", "Iphone 13", "123456789012345", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Nokia:");
Nokia nokia = new Nokia("88888888888", "Nokia 3310", "987654321098765", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");