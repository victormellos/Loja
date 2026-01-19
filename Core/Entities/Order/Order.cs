namespace Loja.Core.Entities.Order;

public class Order
{
    private readonly List<OrderItem> _items;

    public IReadOnlyCollection<OrderItem> Items => _items;

    public Order()
    {
        _items = new List<OrderItem>();
    }

    public void AddItem(Product product, int quantity)
    {
        var item = new OrderItem(product, quantity);
        _items.Add(item);
    }
}