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
    public class DetailsCarModel : PageModel
    {
        private readonly IRepositorioCarro _repo;

        public Carro Carro { get; set;}

        public DetailsCarModel(IRepositorioCarro repositorioCarro)
        {
             _repo = repositorioCarro;
        }

        public void OnGet(int id)
        {
            Carro = _repo.Get(id);
        }
    }
}