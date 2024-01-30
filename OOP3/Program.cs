// See https://aka.ms/new-console-template for more information
using OOP3;

Console.WriteLine("Hello, World!");
IKrediManager tasitKrediManager=new TaşitKrediManager();
IKrediManager ihtiyaçKrediManager = new İhtiyaçKrediManager();
IKrediManager konutKrediManager=new KonutKrediManager();

BasvuruManager basvuruManager=new BasvuruManager();
List<ILoggerServices> services = new List<ILoggerServices>() { new SsmsLoggerServices(),new FileLoggerServices()};


List<IKrediManager> krediler=new List<IKrediManager>() { tasitKrediManager,ihtiyaçKrediManager,konutKrediManager};
basvuruManager.KrediOnBilgilendirmesiYap(krediler);
Console.WriteLine("..........................................");
ILoggerServices dataServices = new DataBaseLoggerServices();
ILoggerServices fileServices=new FileLoggerServices();
basvuruManager.BasvuruYap(tasitKrediManager, services);

Console.WriteLine("..........................................");

BasvuruManager basvuruManager2 = new BasvuruManager();
basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerServices>() { fileServices,new SsmsLoggerServices()});


