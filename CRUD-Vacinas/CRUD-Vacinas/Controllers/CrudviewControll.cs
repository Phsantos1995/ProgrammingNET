using CRUD_Vacinas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Vacinas.Controllers
{
    public class CrudviewControll : Controller
    {
     

        public IActionResult Index()
        {


            List<Crudiview> vacinas = new List<Crudiview>();


            var vacina = new Crudiview();

            vacina.ID = 1;

            vacina.NOME = "CoronaVac";

            vacina.FABRICANTE = "Butantan";

            vacina.INTERVALODOSE = 14;

            vacinas.Add(vacina);




            var vacina2 = new Crudiview();

            vacina2.ID = 1;

            vacina2.NOME = "CoronaVac";

            vacina2.FABRICANTE = "Butantan";

            vacina2.INTERVALODOSE = 14;

            vacinas.Add(vacina2);









            return View(vacinas);

        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Crudiview model)
        {
            return Redirect("/Vacinas/Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var vacina2 = new Crudiview();
            vacina2.ID = 2;
            vacina2.NOME = "AstraZeneca";
            vacina2.FABRICANTE = "Oxford";
            vacina2.NUMDOSES = 2;
            vacina2.INTERVALODOSE = 90;

            return View(vacina2);
        }


        [HttpPost]
        public IActionResult Editar(Crudiview model)
        {
            return Redirect("/Vacinas/Index");
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            return Redirect("/Vacinas/Index");
        }






    }
}

