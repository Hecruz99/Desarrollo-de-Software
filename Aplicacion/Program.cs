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
                    Console.WriteLine(".......................");

                }

            }


            private static void eliminarPersona(int idPersona){ 
                _repo.Delete(idPersona);
                Console.WriteLine("Eliminado");
             }

            private static void adicionarPersona(){ 
                Persona p = new Persona();
                p.Nombre = "Ana Maria";
                p.Apellidos ="Cabrera";
                p.Edad = "45";
                _repo.Add(p);
                Console.WriteLine(":D");
            }

        }
    }

