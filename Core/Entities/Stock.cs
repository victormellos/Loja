namespace Loja.Core.Entities;
public class Stock
{
    public Guid Id { get; private set; }
    public int Quantity { get; private set; }

    public Stock(int quantity)
    {
        Id = Guid.NewGuid();
        Quantity = quantity;
    }

    public void Increase(int amount)
    {
        if(amount < 0)
        {
            throw new ArgumentException("Valor de Estoque inválido.");
        }
        Quantity += amount;
    }
    public void Decrease(int amount)
    {
        if (Quantity < amount)
            throw new InvalidOperationException("Estoque insuficiente");

        Quantity -= amount;
    }
}