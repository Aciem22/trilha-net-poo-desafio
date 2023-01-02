using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("---Nokia---");
Smartphone nokia = new Nokia("9987654321", "G2", "111234", 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.ReadLine();