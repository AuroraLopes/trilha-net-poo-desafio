using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("100", "Win30", "JJAHD5714", 64);
nokia.InstalarAplicativo("DIO");
nokia.ReceberLigacao();
nokia.Ligar();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("120", "ProMax", "HAJDH6846", 128);
iphone.InstalarAplicativo("DIO");
iphone.ReceberLigacao();
iphone.Ligar();