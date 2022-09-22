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
    public class UpdateTecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico _repo;

        public Tecnico tecnico { get; set; }

        public UpdateTecnicoModel(IRepositorioTecnico repositorio){
        _repo = repositorio;
        }
 
    public void OnGet(int Id)
        {
        tecnico = _repo.Get(Id);
        }
    public IActionResult OnPost(Tecnico tecnico){
    
        _repo.Update(tecnico);
        return new RedirectToPageResult("/Tecnico/list");
        }
    }
}
