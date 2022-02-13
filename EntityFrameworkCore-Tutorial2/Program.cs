using EntityFrameworkCore_Tutorial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCore_Tutorial2 {

    class Program {

        static void Main(string[] args) {

            //creating an instance of the class we created
            AppDbContext context = new AppDbContext();

            //var bandcustomer = context.BandCustomers.Find(1);
            //Console.WriteLine($"{bandcustomer.Name} {bandcustomer.Sales:c}");

            List<BandCustomer> bandCustomers = context.BandCustomers.ToList();
            foreach (var bandCustomer in bandCustomers) {
                Console.WriteLine($"{bandCustomer.Name,-20} {bandCustomer.Sales,10:c}");
            }
         
        }
    
    }       
    
}
