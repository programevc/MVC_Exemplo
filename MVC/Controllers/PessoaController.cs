using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            var pessoa = new PessoaModelView();
            pessoa.Nome = "Programe";
            pessoa.SobreNome = "VC";

            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Save(PessoaModelView pessoa)
        {
            if (ModelState.IsValid)
            {

            }
            return Ok();
        }
    }
}
