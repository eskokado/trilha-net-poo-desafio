using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testanto iPhone!");
Iphone iphone = new Iphone("123456789", "iPhone 13", "123456789012345", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine("-------------------------");
Console.WriteLine("Testanto Nokia!");
Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321098765", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
