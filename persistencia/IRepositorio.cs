using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorio
    {
      
      Persona Add(Persona persona);  
      IEnumerable<Persona> GetAll();
      Persona Update(Persona persona);
      void Delete(int IdPersona);
      Persona Get(int IdPersona);
      
    }
}