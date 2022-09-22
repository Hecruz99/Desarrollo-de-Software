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
    public class UpdateCarModel : PageModel
    {
        private readonly IRepositorioCarro _repo;

        public Carro Carro { get; set; }

        public UpdateCarModel(IRepositorioCarro repositorio){
        _repo = repositorio;
        }
 
    public void OnGet(int Id)
        {
        Carro = _repo.Get(Id);
        }
    public IActionResult OnPost(Carro Carro){
    
        _repo.Update(Carro);
        return new RedirectToPageResult("/Carros/list");
        }
    }
}
