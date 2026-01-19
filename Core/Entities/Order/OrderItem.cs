namespace Loja.Core.Entities.Order;


public class OrderItem
{
    
    public Guid Id{get;}    
    public OrderStatus OrderStatus{get; set;}
    public int Quantity{get;}
    public Product Product{get;}


    public OrderItem(Product product, int quantity)
    {
        Id = Guid.NewGuid();

        if (quantity < 1)
        {
            throw new ArgumentException("Quantidade deve ser maior que zero.");
        }
        
        Quantity = quantity;
        Product = product;

    }
}