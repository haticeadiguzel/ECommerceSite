using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            //CustomerTest();
            //OrderTest();


            Console.ReadLine();
        }

        private static void OrderTest()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var order in orderManager.GetAll().Data)
            {
                Console.WriteLine(order.OrderId);
            }
           
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            /*foreach (var product in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.ProductName);
            }*/

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                    Console.WriteLine(result.Message);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }
    }
}
