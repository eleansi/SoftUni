using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var dataMapper = new DataMapper();
            var categories = dataMapper.GetAllCategories();
            var products = dataMapper.GetAllProducts();
            var orders = dataMapper.GetAllOrders();

            // Names of the 5 most expensive products
            var mostExpensive = products
                .OrderByDescending(product => product.UnitPrice)
                .Take(5)
                .Select(product => product.Name);
            Console.WriteLine(string.Join(Environment.NewLine, mostExpensive));

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var numberOfProducts = products
                .GroupBy(product => product.CategoryId)
                .Select(group =>
                    new
                    {
                        Category = categories
                            .First(category => category.Id == group.Key).Name,
                        Count = group.Count()
                    })
                .ToList();
            foreach (var item in numberOfProducts)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var orderedByQuantity = orders
                .GroupBy(order => order.ProductId)
                .Select(group =>
                    new
                    {
                        Product = products
                            .First(product => product.Id == group.Key).Name,
                        Quantities = group.Sum(grpgrp => grpgrp.Quantity)
                    })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in orderedByQuantity)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var mostProfitableCategory = orders
                .GroupBy(order => order.ProductId)
                .Select(g => new { CategoryId = products.First(p => p.Id == g.Key).CategoryId, Price = products.First(p => p.Id == g.Key).UnitPrice, Quantity = g.Sum(p => p.Quantity) })
                .GroupBy(gg => gg.CategoryId)
                .Select(grp => new { CategoryName = categories.First(c => c.Id == grp.Key).Name, TotalQuantity = grp.Sum(g => g.Quantity * g.Price) })
                .OrderByDescending(g => g.TotalQuantity)
                .First();
            Console.WriteLine("{0}: {1}", mostProfitableCategory.CategoryName, mostProfitableCategory.TotalQuantity);
        }
    }
}
