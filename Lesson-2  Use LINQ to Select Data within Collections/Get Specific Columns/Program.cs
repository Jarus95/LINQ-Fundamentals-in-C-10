using DataLayer.Entities;
using LINQSamples;

ViewModelBase viewModelBase = new ViewModelBase();
List<Product> products = viewModelBase.GetProducts();
List<Product> listQuery = new();
List<Product> listMethod = new();
// Linq query syntax
listQuery = (from prod in products
             select new Product
             {
                 ProductID = prod.ProductID,
                 ListPrice = prod.ListPrice

             }).ToList();
//linq method syntax
listMethod = products.Select(x => new Product
{
    ProductID = x.ProductID,
    ListPrice = x.ListPrice


}).ToList();

foreach (Product prod in listMethod)
{
    Console.WriteLine(prod);
}