using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone i1 = new Iphone("1111", "I 11", "12345678", 256);
Nokia n1 = new Nokia("2222", "N 10", "87456321", 128);

Console.WriteLine("---------------");
Console.WriteLine("Teste do Iphone");
Console.WriteLine("---------------");
i1.InstalarAplicativo("Google Maps");
i1.Ligar();
i1.ReceberLigacao();
Console.WriteLine("---------------");
Console.WriteLine("Teste do Nokia");
Console.WriteLine("---------------");
n1.InstalarAplicativo("Google Maps");
n1.Ligar();
n1.ReceberLigacao();