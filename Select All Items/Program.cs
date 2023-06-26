using DataLayer.Entities;
using LINQSamples;

ViewModelBase viewModelBase = new ViewModelBase();
List<Product> products = viewModelBase.GetProducts();
List<Product> listQuery = new();
List<Product> listMethod = new();
// Linq query syntax
listQuery = (from prod in products select prod).ToList();
//linq method syntax
listMethod = products.Select(x => x).ToList();

foreach (Product prod in listMethod)
{
    Console.WriteLine(prod);
}