//SELECT * FROM Products WHERE ListPrice > 1000

using DataLayer.Entities;
using LINQSamples;


ViewModelBase viewModelBase = new ViewModelBase();

//loop
List<Product> list_loop = new();
List<Product> products_loop = viewModelBase.GetProducts();
foreach (Product product in products_loop)
{
    if (product.ListPrice > 1000)
    {
        list_loop.Add(product);
    }
}
 
//LINQ


List<Product> products = viewModelBase.GetProducts();
var list = (from prod in products where prod.ListPrice > 1000 select prod).ToList();
Console.WriteLine();


