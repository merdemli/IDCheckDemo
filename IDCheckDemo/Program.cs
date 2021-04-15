using IDCheckDemo.Abstract;
using IDCheckDemo.Adapters;
using IDCheckDemo.Concrete;
using IDCheckDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCheckDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1988, 10, 18),
                FirstName = "MERVE",
                LastName = "ERDEMLİ",
                NationalityId = 111111111
            });
            Console.ReadLine();
            
        }
    }
}
