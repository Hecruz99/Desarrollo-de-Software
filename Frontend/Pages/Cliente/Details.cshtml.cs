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
 public class DetailsClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;

        public Cliente Cliente { get; set;}

        public DetailsClienteModel(IRepositorioCliente repositorioCliente)
        {
            _repo = repositorioCliente;
        }

        public void OnGet(int id)
        {
            Cliente = _repo.Get(id);
        }
    }
}