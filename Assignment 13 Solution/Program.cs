using static Session_13.ListGenerators;
namespace Assignment_13_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Elemnt Operators

            #region Q1

            //var result = ProductList.First(p => p.UnitsInStock == 0);

            //Console.WriteLine(result); 

            #endregion

            #region Q2

            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine(result);

            #endregion

            #region Q3

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(n => n > 5).Skip(1).First();

            //Console.WriteLine(result);

            #endregion

            #endregion


            #region Aggregate Operators

            #region Q1

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(n => n % 2 == 1).Count();

            //Console.WriteLine(result);

            #endregion

            #region Q2

            //var result = CustomerList.Select(c => new
            //{
            //    CustomerName = c.Name,
            //    OrderCount = c.Orders.Count()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CustomerName} - {item.OrderCount}");
            //}

            #endregion

            #region Q3

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(g => new
            //                        {
            //                            Category = g.Key,
            //                            ProductCount = g.Count()
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductCount}");
            //}

            #endregion

            #region Q4

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();

            //Console.WriteLine(result);

            #endregion

            #region Q5

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Sum(w => w.Length);

            //Console.WriteLine(result);

            #endregion

            #region Q7

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Min(w => w.Length);

            //Console.WriteLine(result);

            #endregion

            #region Q8

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Max(w => w.Length);

            //Console.WriteLine(result);

            #endregion

            #region Q9

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(g => new
            //                        {
            //                            Category = g.Key,
            //                            TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - {item.TotalUnitsInStock}");
            //}

            #endregion

            #region Q10

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(g => new
            //                        {
            //                            Category = g.Key,
            //                            CheapestPrice = g.Min(p => p.UnitsInStock)
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - {item.CheapestPrice}");
            //}

            #endregion

            #region Q11

            //var result =
            //from p in ProductList
            //group p by p.Category into g
            //let minPrice = g.Min(p => p.UnitPrice)
            //from p in g
            //where p.UnitPrice == minPrice
            //select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q12

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(g => new
            //                        {
            //                            Category = g.Key,
            //                            HighestPrice = g.Max(p => p.UnitsInStock)
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - {item.HighestPrice}");
            //}

            #endregion

            #region Q13

            //var result =
            //from p in ProductList
            //group p by p.Category into g
            //let HighestPrice = g.Max(p => p.UnitPrice)
            //from p in g
            //where p.UnitPrice == HighestPrice
            //select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q14

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Select(g => new
            //                        {
            //                            Category = g.Key,
            //                            AvgPrice = g.Average(p => p.UnitsInStock)
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - {item.AvgPrice}");
            //}

            #endregion

            #endregion


            #region Set Operators

            #region Q1

            //var result = ProductList.Select(n => n.Category)
            //                        .Distinct();

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q2

            //var result = (ProductList.Select(p => p.ProductName[0])).Union(CustomerList
            //                                                        .Select(c => c.Name[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3

            //var result = (ProductList.Select(p => p.ProductName[0])).Intersect(CustomerList
            //                                                        .Select(c => c.Name[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4

            //var result = (ProductList.Select(p => p.ProductName[0])).Except(CustomerList
            //                                                        .Select(c => c.Name[0]));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q5

            //var result = (ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)))
            //    .Concat(CustomerList
            //    .Select(c => c.Name.Substring(c.Name.Length - 3)));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion


            #region Partitioning Operators

            #region Q1

            //var result = CustomerList.Where(c => c.City == "WA")
            //            .SelectMany(c => c.Orders)
            //            .Take(3);

            //foreach (var order in result)
            //    Console.WriteLine(order);

            #endregion

            #region Q2

            //var result = CustomerList.Where(c => c.City == "WA")
            //            .SelectMany(c => c.Orders)
            //            .Skip(2);

            //foreach (var order in result)
            //    Console.WriteLine(order);

            #endregion

            #region Q3

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q5

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((n, index) => n >= index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion


            #region Quantifiers

            #region Q1

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Any(w => w.Contains("ei"));

            //Console.WriteLine(result);

            #endregion

            #region Q2

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Where(g => g.Any(p => p.UnitsInStock == 0));

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");

            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  {product.ProductName}");
            //    }
            //}

            #endregion

            #region Q3

            //var result = ProductList.GroupBy(p => p.Category)
            //                        .Where(g => g.All(p => p.UnitsInStock == 0));

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");

            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  {product.ProductName}");
            //    }
            //}

            #endregion

            #endregion


            #region Grouping Operators

            #region Q1

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");

            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            #endregion

            #region Q2

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.GroupBy(w => w[0]);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");

            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            #endregion

            #region Q3

            //string[] Arr = {"from", "salt", "earn", "last", "near", "form"};

            //var result = Arr.GroupBy(word => word, new AnagramComparer());

            //foreach (var group in result)
            //{
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }

            //    Console.WriteLine("---------");
            //}

            #endregion

            #endregion


        }
    }
}
