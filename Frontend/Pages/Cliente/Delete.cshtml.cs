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
    public class DeleteClienteModel : PageModel
    {

        private readonly IRepositorioCliente _repo;

        public Cliente Cliente { get; set;}

        public DeleteClienteModel(IRepositorioCliente repo)    
        {
            _repo = repo;
        }
    
        public void OnGet(int id)
        {
            _repo.Get(id);
           
        }

        public  IActionResult OnPost(int id)
        {
            _repo.Delete(id);
            return new RedirectToPageResult("/Cliente/List");
            
        }
    }
}
