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
    public class CreateCarModel : PageModel
    {
        private readonly IRepositorioCarro _repo;
        public Carro Carro { get; set;}

        public CreateCarModel(IRepositorioCarro RepositorioCarro)
        
        {
            _repo = RepositorioCarro;
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
