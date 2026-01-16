using Loja.Core.ValueObjects;

namespace Loja.Core.Entities
{
    public class Consumer{

        public Guid Id{get;}
        public string Name{get;}
        public Consumer(string name)
        {
            Id = Guid.NewGuid();
            Name = name ?? throw new ArgumentException("Nome do produto não declarado.");
        }

        public void BuyProduct(int quantity)
        {
            
        }
    }
}