using DesafioPOO.Models;

// Implementado!!! TESTES

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Nokia Tijolao", "1111111111111111", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("987654", "iPhone 12", "2222222222222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");