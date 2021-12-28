using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Lesson16_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxEmployee = products[0];
            foreach (Product e in products)
            {
                if (e.Price > maxEmployee.Price)
                {
                    maxEmployee = e;
                }
            }
            Console.WriteLine($"{maxEmployee.Code} {maxEmployee.Name} {maxEmployee.Price}");
            Console.ReadKey();
        }
    }
}
