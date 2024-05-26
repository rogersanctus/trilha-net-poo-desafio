using DesafioPOO.Models;

Smartphone nokia = new Nokia("551198761234", "5200", "1234567890", 2);
Smartphone iphone = new Iphone("5521998874321", "11", "32112345665", 128);

Console.WriteLine("Smatphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("OApp");
nokia.InstalarAplicativo("MiniSmallApp");
nokia.ReceberLigacao();

Console.WriteLine("---");

Console.WriteLine("Smatphone Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("All-Node_Modules");

