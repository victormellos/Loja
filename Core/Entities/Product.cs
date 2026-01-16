using Loja.Core.ValueObjects;

namespace Loja.Core.Entities
{
    public class Product
    {
        public Guid Id{get;}
        public string Name{get;}
        public Stock Stock{get; private set;}
        public Money Price{get; private set;}
        public Product(string name, Money price)
        {
            Id = Guid.NewGuid();
            Stock = new Stock(quantity: 0);
            Name = name ?? throw new ArgumentException("Nome do produto não declarado.");
            Price = price;
        }

        public void SellProduct(int quantity)
        {
            Stock.Decrease(quantity);
        }
    }
}