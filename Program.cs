using DesafioPOO.Models;

//Testes da classe Nokia
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("+5581995083305", "Nokia 3310", "001970-01-010000-0", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp.apk");
nokia.InstalarAplicativo("telegram.apk");
Console.WriteLine("\nApps insalados:");
foreach (var item in nokia.Aplicativos)
{
    Console.WriteLine(item);
}
nokia.DesinstalarAplicativo("telegram.apk");
Console.WriteLine("\nApps insalados:");
foreach (var item in nokia.Aplicativos)
{
    Console.WriteLine(item);
}

//Testes da classe Iphone
Console.WriteLine("\nSmartphone iPhone");
Smartphone iphone = new Iphone("+5581985170042", "Iphone 5", "002970-02-020000-0", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram.ipa");
Console.WriteLine("\nApps insalados:");
foreach (var item in iphone.Aplicativos)
{
    Console.WriteLine(item);
}
//Aqui deverá retornar uma mensagem informando que o app não foi encontrado
iphone.DesinstalarAplicativo("whatsapp.ipa");
//Aqui deverá dar um exception foi o formato não é suportado pelo sistema ios
iphone.InstalarAplicativo("whatsapp.apk");
