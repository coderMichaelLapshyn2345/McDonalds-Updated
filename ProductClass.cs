using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace МакДональдс
{
    public class ProductClass
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Kcal { get; set; }
        public string CollectionStatus { get; set; }
        public ProductClass(string name, double price, int kcal, string collectionStatus)
        {
            Name = name;
            Price = price;
            Kcal = kcal;
            CollectionStatus = collectionStatus;
        }
    }
}
