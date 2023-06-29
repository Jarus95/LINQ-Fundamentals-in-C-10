//SELECT DISTINCT Color FROM Products
//Unique value



using DataLayer.Entities;
using LINQSamples;
using System.Linq;

ViewModelBase viewModelBase = new ViewModelBase();
List<Product> products = viewModelBase.GetProducts();

//loop
List<string> list_loop = new();
foreach (Product product in products)
{
    if (!list_loop.Contains(product.Color))
    {
        list_loop.Add(product.Color);
    }
}

//LINQ



var list = (from prod in products select prod.Color).Distinct().ToList();
Console.WriteLine();


