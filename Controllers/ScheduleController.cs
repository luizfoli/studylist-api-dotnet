using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using studylist.Models;

namespace studylist.Controllers
{
    [ApiController]
    [Route("api/schedule")]
    public class ScheduleController : ControllerBase 
    {
        private static readonly List<Study> Studies = new List<Study>
        {
            new Study{name = "Terminar a leitura do livro Refactoring"},
            new Study{name = "Aprimorar conhecimento em Algoritmos e Estrutura de Dados"}
        };

        [HttpGet]
        public ActionResult<List<Study>> Get()
        {
            return Studies;
        }

        [HttpPost]
        public ActionResult<List<Study>> Post([FromBody] Study NewStudy)
        {
            Studies.Add(NewStudy);
            return Studies;
        }

    }
}