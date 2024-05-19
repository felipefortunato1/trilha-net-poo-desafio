using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1681381343", modelo: "FFF111", imei: "184648343", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "987540000", modelo: "FFF222", imei: "13438739", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


