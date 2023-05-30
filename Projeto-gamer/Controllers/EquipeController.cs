using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_gamer.Infra;
using Projeto_gamer.Models;

namespace Projeto_gamer.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

                                        //controller/action
        [Route("Listar")]//http://localhost/Equipe/Listar
        public IActionResult Index()
        {
            //"mochila" que contém a lista das equipes
            // podemos usar  essa mochila na view da equipe
           ViewBag.Equipe = c.Equipe.ToList();

           //retorna  a view de equipe
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            novaEquipe.Nome = form["Nome"].ToString();

            c.Equipe.Add(novaEquipe);

            c.SaveChanges();

            ViewBag.Equipe = c.Equipe.ToList();
            return LocalRedirect("~/Equipe/LIstar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}