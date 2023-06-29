//SELECT MIN(ListPrice) FROM Products
//SELECT MAX(ListPrice) FROM Products
//SELECT AVG(ListPrice) FROM Products
//SELECT * FROM Products ORDER BY Name Desc

using DataLayer.Entities;
using LINQSamples;

ViewModelBase viewModelBase = new ViewModelBase();
List<Product> products = viewModelBase.GetProducts();

//loop

decimal min = decimal.MaxValue;
foreach (Product product in products)
{
    if (product.ListPrice < min)
    {
        min = product.ListPrice;
    }
}

decimal max = 0;
foreach (Product product in products)
{
    if (product.ListPrice > max)
    {
        max = product.ListPrice;
    }
}

decimal count = 0;
foreach (Product product in products)
{
    count += product.ListPrice;
}

var avg = count / products.Count;


//LINQ

var _min = (from prod in products select prod.ListPrice).Min();
var _max = (from prod in products select prod.ListPrice).Max();
var _avg = (from prod in products select prod.ListPrice).Average();
var list = (from prod in products orderby prod.Name descending select prod).ToList();


Console.WriteLine();

