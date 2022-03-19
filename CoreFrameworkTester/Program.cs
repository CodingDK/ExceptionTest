// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CoreFrameworkTester.Service;

try
{
    var carService = new CarService();

    var allCars = carService.GetAll();

    carService.MakeException(allCars);

    Console.WriteLine("DONE");
}
catch (Exception ex)
{
    Console.WriteLine("Exception:" + Environment.NewLine);
    Console.WriteLine(ex.ToString());
}
Console.ReadLine();