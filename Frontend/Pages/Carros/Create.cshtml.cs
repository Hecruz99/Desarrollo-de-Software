using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorio _repo;
        public Carro Carro { get; set;}

        public CreateModel(IRepositorio repositorio)
        
        {
            _repo = repositorio;
        }

        public void OnGet()
        {
        }
         public IActionResult OnPost(Carro carro)
        {
            _repo.Add(carro);
            return new RedirectToPageResult("/Carros/List");
        }
    }
}
