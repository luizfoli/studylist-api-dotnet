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
            new Study{Id = 1, Name = "Terminar a leitura do livro Refactoring"},
            new Study{Id = 2, Name = "Aprimorar conhecimento em Algoritmos e Estrutura de Dados"}
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

        [HttpDelete]
        public ActionResult<List<Study>> Delete([FromQuery] int Id)
        {
            Studies.Remove(Studies.Find(Study => Study.Id == Id));
            return Studies;
        }
    }
}