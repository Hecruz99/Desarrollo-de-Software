﻿using System;
using Dominio;
using persistencia;

namespace Aplicacion
{
    class Program
    {
        private static IRepositorio _repo = new Repositorio(new ApplicationContext());
        
            static void Main(string[] args)
            {
              adicionarPersona();  
              obtenerPersonas();
              //eliminarPersona();
            }

            private static void obtenerPersonas(){ 
                var personas = _repo.GetAll();

                foreach (var persona in personas)
                {
                    Console.WriteLine("El nombre es: " + persona.Nombre);
                    Console.WriteLine("Los Apellidos son: " + persona.Apellidos);
                    Console.WriteLine("La Edad es: " + persona.Edad);
                    Console.WriteLine("El Telefono es: " + persona.Telefono);
                    Console.WriteLine("La Direccion es: " + persona.Direccion);
                    Console.WriteLine("La Cedula es: " + persona.Cedula);
                    Console.WriteLine("..................................");

                }

            }


            private static void eliminarPersona(int idPersona){ 
                _repo.Delete(idPersona);
                Console.WriteLine("Eliminado");
             }

            private static void adicionarPersona(){ 
                Persona p = new Persona();
                p.Nombre = "William Alberto ";
                p.Apellidos ="Cubillos Sanchez";
                p.Edad = "25";
                p.Telefono = 2435467;
                p.Direccion = "calle 78 98 89";
                p.Cedula = 807768762;
                _repo.Add(p);
                Console.WriteLine(":D");
            }

        }
    }

