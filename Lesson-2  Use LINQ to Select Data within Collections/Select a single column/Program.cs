using DataLayer.Entities;
using LINQSamples;

ViewModelBase viewModelBase = new ViewModelBase();
List<Product> products = viewModelBase.GetProducts();
List<string> listQuery = new();
List<string> listMethod = new();
// Linq query syntax
listQuery = (from prod in products select prod.Name).ToList();
//linq method syntax
listMethod = products.Select(x => x.Name).ToList();

foreach (var prod in listMethod)
{
    Console.WriteLine(prod);
}