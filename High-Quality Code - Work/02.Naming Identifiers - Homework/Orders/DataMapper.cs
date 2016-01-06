using System.Collections.Generic;
using System.Linq;
using System.IO;
using Orders.Models;

namespace Orders
{
    public class DataMapper
    {
        private string categoriesFileName;
        private string productsFileName;
        private string ordersFileName;

        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.categoriesFileName = categoriesFileName;
            this.productsFileName = productsFileName;
            this.ordersFileName = ordersFileName;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = ReadFileLines(this.categoriesFileName, true);
            return categories
                .Select(category => category.Split(','))
                .Select(category => new Category
                {
                    Id = int.Parse(category[0]),
                    Name = category[1],
                    Description = category[2]
                });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = ReadFileLines(this.productsFileName, true);
            return products
                .Select(product => product.Split(','))
                .Select(product => new Product
                {
                    Id = int.Parse(product[0]),
                    Name = product[1],
                    CategoryId = int.Parse(product[2]),
                    UnitPrice = decimal.Parse(product[3]),
                    UnitsInStock = int.Parse(product[4]),
                });
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = ReadFileLines(this.ordersFileName, true);
            return orders
                .Select(order => order.Split(','))
                .Select(order => new Order
                {
                    Id = int.Parse(order[0]),
                    ProductId = int.Parse(order[1]),
                    Quantity = int.Parse(order[2]),
                    Discount = decimal.Parse(order[3]),
                });
        }

        private List<string> ReadFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}
