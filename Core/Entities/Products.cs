using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Core.Entities
{
    public class Products
    {
        public Guid ID{get;}
        public string Name{get;}
        //public Stock Stock{get; private set}
        //public Money Price{get; private set}

        public Products(string name)
        {
            ID = Guid.NewGuid();
            Name = name ?? throw new ArgumentException("Nome do produto não declarado.");
        

        }
    }
}