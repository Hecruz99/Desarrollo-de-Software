using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorioCliente
    {
      
      Cliente Add(Cliente cliente);  
      IEnumerable<Cliente> GetAll();
      Cliente Update(Cliente cliente);
      void Delete(int IdCliente);
      Cliente Get(int IdCliente);
      
    }
}