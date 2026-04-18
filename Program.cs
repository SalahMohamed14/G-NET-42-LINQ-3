using G_NET_42_LINQ_1.Models;

namespace G_NET_42_LINQ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data Source
            List<Product> ProductList = new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18, UnitsInStock = 39 },
                new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19, UnitsInStock = 17 },
                new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10, UnitsInStock = 13 },
                new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22, UnitsInStock = 53 },
                new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.35m, UnitsInStock = 0 },
                new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25, UnitsInStock = 120 },
                new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce", UnitPrice = 30, UnitsInStock = 15 },
                new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments", UnitPrice = 40, UnitsInStock = 6 },
                new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97, UnitsInStock = 29 },
                new Product { ProductID = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31, UnitsInStock = 20 },
                new Product { ProductID = 11, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6, UnitsInStock = 24 },
                new Product { ProductID = 12, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.25m, UnitsInStock = 35 },
                new Product { ProductID = 13, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.5m, UnitsInStock = 39 },
                new Product { ProductID = 14, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.45m, UnitsInStock = 29 },
                new Product { ProductID = 15, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39, UnitsInStock = 0 }
            };
            #endregion

            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var res = setA.Except(setB);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var res = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q15
            //Dictionary<int, Product> productDict = ProductList
            //    .ToDictionary(p => p.ProductID);

            //if (productDict.TryGetValue(15, out Product product))
            //{
            //    Console.WriteLine($"ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found");
            //} 
            #endregion

            #region Q18
            //var table7 = Enumerable.Range(1, 10)
            //            .Select(x => $"7 x {x} = {7 * x}");

            //foreach (var row in table7)
            //{
            //    Console.WriteLine(row);
            //} 
            #endregion

            #region Q19
            //var evenNumbers = Enumerable.Range(1, 30)
            //            .Where(x => x % 2 == 0);

            //foreach (var row in evenNumbers)
            //{
            //    Console.WriteLine(row);
            //} 
            #endregion

            #region Q20
            //var result20 = ProductList
            //    .Take(3)
            //    .Select(p => p.ProductName)
            //    .Concat(customers.Take(3).Select(c => c.CompanyName));

            //foreach (var item in result20)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q21
            //var result21 = ProductList
            //.Zip(customers, (p, c) => $"{p.Name} sold to {c.CompanyName}");

            //foreach (var item in result21)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

        }
    }
}
