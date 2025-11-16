using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"54982435167",modelo:"111111111",Imei:"76386237",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero:"54982435167",modelo:"111111111",Imei:"76386237",memoria:64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


