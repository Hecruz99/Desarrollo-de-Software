using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class IRepositorio
    {
      Persona Add(Persona persona);  
      IEnumerable<persona> GetAll();
      Persona Update(Persona persona);
      void Delete(int idPersona);
      Persona Get(int IdPersona);
      
    }
}