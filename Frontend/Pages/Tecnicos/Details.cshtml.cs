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
    public class DetailsTecModel : PageModel
    {
        private readonly IRepositorio _repo;

        public Persona Persona { get; set;}

        public DetailsTecModel(IRepositorio repositorio)
        {
            _repo = repositorio;
        }

        public void OnGet(int id)
        {
            Persona = _repo.Get(id);
        }
    }
}
