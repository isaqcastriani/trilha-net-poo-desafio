using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Teste com a classe Nokia
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111111111111111", memoria: 64);
        Console.WriteLine("Testando o Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine();

        // Teste com a classe Iphone
        Smartphone iphone = new Iphone(numero: "7891011", modelo: "iPhone 13", imei: "222222222222222", memoria: 128);
        Console.WriteLine("Testando o iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
