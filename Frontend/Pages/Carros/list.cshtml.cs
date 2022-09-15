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
    public class listCarModel : PageModel
    {
        private readonly IRepositorioCarro _repo;
        public IEnumerable<Carro> Carros {get; set; }
        public listCarModel(IRepositorioCarro RepositorioCarro)
        {
            _repo = RepositorioCarro;
        }
        public void OnGet()
        {
            Carros =  _repo.GetAll();            
        }
           
        }
    }

