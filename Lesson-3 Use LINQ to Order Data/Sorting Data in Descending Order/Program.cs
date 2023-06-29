using DataLayer.Entities;
using LINQSamples;

ViewModelBase viewModelBase = new ViewModelBase();
List<Product> products = viewModelBase.GetProducts();
List<Product> listQuery = new();
List<Product> listMethod = new();
// Linq query syntax
listQuery = (from prod in products orderby prod.Name descending select prod).ToList();
//linq method syntax
listMethod = products.OrderByDescending(prod => prod.Name).ToList();

//}).ToList();

foreach (Product prod in listQuery)
{
    Console.WriteLine(prod);
}