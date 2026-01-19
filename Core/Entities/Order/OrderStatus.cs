namespace Loja.Core.Entities.Order;

public enum OrderStatus
{
    Criado = 1,
    Processando = 2,
    Pago = 3,
    Enviado = 4,
    Entregue = 5,
    Cancelado = 99
}
