using System;
using Dominio;
using persistencia;

namespace Aplicacion
{
    class Program
    {
        private static IRepositorio _repo = new Repositorio(new ApplicationContext())
        
            static void Main(string[] args)
            {
            }

            private static void obtenerPersonas(){ 
                var personas = _repo.GetAll();

                foreach (var persona in personas)
                {
                    console.WriteLine("El nombre es: " + persona.Nombre);
                    console.WriteLine("Los Apellidos son: " + persona.Apellidos);
                    console.WriteLine("La Edad es: " + persona.Edad);
                    console.WriteLine("..........................");

                }

            }


            private static void eliminarPersona(int idPersona){ 
                _repo.Delete(idPersona);
                console.WriteLine("Eliminado");
             }

            private static void adicionarPersona(){ 
                Persona p = new Persona();
                p.Nombre = "Jonathan";
                P.Apellidos ="Rodriguez Ramirez";
                p.Edad = "30";
                _repo.Add(p);
                console.WriteLine(":D");
            }

        }
    }
}
