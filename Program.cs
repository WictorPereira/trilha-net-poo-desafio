using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Console.WriteLine("Testando Nokia:");
        Smartphone nokia = new Nokia("123456789", "Nokia Modelo X", "111111111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine($"Modelo: {nokia.Modelo}");
        Console.WriteLine($"Numero: {nokia.Numero}");

        Console.WriteLine();

        // Testando a classe Iphone
        Console.WriteLine("Testando iPhone:");
        Smartphone iphone = new Iphone("987654321", "iPhone 13", "222222222222", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        Console.WriteLine($"Modelo: {iphone.Modelo}");
        Console.WriteLine($"Numero: {iphone.Numero}");
    }
}