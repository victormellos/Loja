using Loja.Core.ValueObjects;

namespace Loja.Core.Entities
{
    public class User{

        public Guid Id{get;}
        public string Name{get;}
        public Cpf Cpf{get;}

        public User(string name, string cpf)
        {
            Id = Guid.NewGuid();
            Name = name ?? throw new ArgumentException("Nome do Usuário não declarado.");

            Cpf = new Cpf(cpf);
        }

        public void BuyProduct(int quantity)
        {
            
        }
    }
}