using RandREng.MeasuresCore.Data;
using RandREng.MeasuresCore.Domain;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MeasureEntities context = new MeasureEntities())
            {
                Client parent = new Client { CompanyName = "Home Depot", Address = new Address() };
                Client store = new Client { CompanyName = "Store 127", Address = new Address(), Parent = parent };
                context.Customers.Add(store);
                context.Customers.Add(parent);
                int count = context.SaveChanges();
                List<Client> customers = context.Customers.ToList();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
