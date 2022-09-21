using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using persistencia;


namespace MyApp.Namespace
{
    public class listTecModel : PageModel
    {
        private readonly IRepositorio _repo;
        public IEnumerable<Persona> Personas {get; set; }
        public listTecModel(IRepositorio Repositorio)
        {
            _repo = Repositorio;
        }
        public void OnGet()
        {
            Personas =  _repo.GetAll();            
        }
           
        }
    }

