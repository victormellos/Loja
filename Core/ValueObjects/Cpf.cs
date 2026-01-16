namespace Loja.Core.ValueObjects
{
    public sealed class Cpf
    {
        
        public Cpf(string cpf)
        {
            if (!IsValid(cpf))
            {
                throw new ArgumentException("Cpf inválido");
            }
            
        }
    private bool IsValid(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf)){
                return false;
            }
            cpf = string.Concat(cpf.Where(char.IsDigit));

            if (cpf.Length != 11)
            {
                return false;
            }

            return true;
        }
    }
}