//SELECT DISTINCT Color FROM Products
//Unique value



using DataLayer.Entities;
using LINQSamples;
using System.Linq;

ViewModelBase viewModelBase = new ViewModelBase();

//loop
List<string> list_loop = new();
List<Product> products_loop = viewModelBase.GetProducts();
foreach (Product product in products_loop)
{
    if (!list_loop.Contains(product.Color))
    {
        list_loop.Add(product.Color);
    }
}

//LINQ


List<Product> products = viewModelBase.GetProducts();
var list = (from prod in products select prod.Color).Distinct().ToList();
Console.WriteLine();


