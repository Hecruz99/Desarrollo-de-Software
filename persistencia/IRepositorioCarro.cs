using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorioCarro
    {
      
      Carro Add(Carro carro);  
      IEnumerable<Carro> GetAll();
      Carro Update(Carro carro);
      void Delete(int IdCarro);
      Carro Get(int IdCarro);
      
    }
}