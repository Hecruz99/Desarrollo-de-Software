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
public class DetailsTecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico _repo;

        public Tecnico Tecnico { get; set;}

        public DetailsTecnicoModel(IRepositorioTecnico repositorioTecnico)
        {
            _repo = repositorioTecnico;
        }

        public void OnGet(int id)
        {
            Tecnico = _repo.Get(id);
        }
    }
}