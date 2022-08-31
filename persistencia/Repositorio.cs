using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace persistencia
{
    public class Repositorio: IRepositorio
    {
        private readonly ApplicationContext _applicationContext;
        public Repositorio(ApplicationContext applicationContext){
            _applicationContext = _applicationContext;
        }

        public Repositorio(){}
        persona IRepositorio.Add(Persona persona)
        {
            var new_persona = _applicationContext.personas.Add(persona);
            _applicationContext.SaveChanges();
            return new_persona.Entity;
        }

        void IRepositorio.Delete(int idPersona)
        {
            var personaEncontrada = _applicationContext.personas.FirstOrDefault(
                p => p.Id == Idpersona
            );
            if(personaEncontrada == mull)
            return;
            _applicationContext.Remove(personaEncontrada);
            _applicationContext.SaveChanges();
        };

        IEnumerable<Persona> IRepositorio.GetAll(){
            return _applicationContext.personas;
        }

        Persona IRepositorio.Get(int idPersona){
            var persona = _applicationContext.personas.FirstOrDefault(
                p => p.Id == Idpersona
            );
            
        }

        Persona IRepositorio.Update(Persona persona){
           var personaEncontrada = _applicationContext.personas.FirstOrDefault(
                p => p.Id == Idpersona

           );

           if(personaEncontrada != null){
            personaEncontrada.Nombre = persona.Nombre;
            personaEncontrada.Edad = persona.Edad;
            personaEncontrada.Apellidos = persona.Apellidos;
           }      

           _applicationContext.SaveChanges();
           return personaEncontrada;
        }
    }
}