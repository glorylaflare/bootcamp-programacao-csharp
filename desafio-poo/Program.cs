using desafio_poo.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Nokia 100", "12AF20DKS20A", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone(numero: "45623", modelo: "iPhone 9", imei: "POS2910SJK2", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");