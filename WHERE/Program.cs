//SELECT * FROM Products WHERE ListPrice > 1000

using DataLayer.Entities;
using LINQSamples;


ViewModelBase viewModelBase = new ViewModelBase();
List<Product> products = viewModelBase.GetProducts();
//loop
List<Product> list_loop = new();
foreach (Product product in products)
{
    if (product.ListPrice > 1000)
    {
        list_loop.Add(product);
    }
}

//LINQ



var list = (from prod in products where prod.ListPrice > 1000 select prod).ToList();
Console.WriteLine();


