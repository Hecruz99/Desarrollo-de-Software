using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorioTecnico
    {
      
      Tecnico Add(Tecnico tecnico);  
      IEnumerable<Tecnico> GetAll();
      Tecnico Update(Tecnico tecnico);
      void Delete(int IdTecnico);
      Tecnico Get(int IdTecnico);
      
    }
}