using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("123456789", "Nokia Modelo X", "123456789012345", 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatssap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("998971890","Iphone XS","5415578898888", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("instagram");
