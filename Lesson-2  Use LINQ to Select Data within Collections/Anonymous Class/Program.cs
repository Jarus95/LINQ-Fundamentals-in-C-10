using DataLayer.Entities;
using LINQSamples;

ViewModelBase viewModelBase = new ViewModelBase();
List<Product> products = viewModelBase.GetProducts();

// Linq query syntax
var listQuery = (from prod in products
                 select new
                 {
                     id = prod.ProductID,
                     name = prod.Name,
                     color = prod.Color,
                     size = prod.Size
                 });
//linq method syntax
var listMethod = products.Select(x => new
{
    id = x.ProductID,
    name = x.Name,
    color = x.Color,
    size = x.Size


});

foreach (var prod in listMethod)
{
    Console.WriteLine(prod);
}