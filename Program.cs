using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


string nomeApp = "instagram";

Smartphone iphone1 = new Iphone("(81 1234-5678)", "iPhone 12", "123456789", 100);
 Smartphone nokia1 = new Nokia("(81 4321-5678)", "Nokia 3310", "987654321", 50);

// Testar métodos
Console.WriteLine("especificações do iphone:\n");
iphone1.Ligar();
iphone1.InstalarAplicativo(nomeApp);

Console.WriteLine("\nespecificações do nokia:\n");
nokia1.Ligar();
nokia1.InstalarAplicativo(nomeApp);