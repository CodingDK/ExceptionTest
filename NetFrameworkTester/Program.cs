using NetFrameworkTester.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
