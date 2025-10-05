using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // INstanciando dados para o Nokia
        Smartphone nokia = new Nokia(numero: "1199999999", modelo: "Nokia 3310", imei: "1234567890", memoria: 32);
        Console.WriteLine("=== Teste do Nokia ===");
        Console.WriteLine($"Modelo: {nokia.Modelo}, Número: {nokia.Numero}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}GB");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Instanciando dados para o iPhone
        Smartphone iphone = new Iphone(numero: "1198888888", modelo: "iPhone 13", imei: "0987654321", memoria: 128);
        Console.WriteLine("=== Teste do iPhone ===");
        Console.WriteLine($"Modelo: {iphone.Modelo}, Número: {iphone.Numero}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}GB");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
