using Microsoft.AspNetCore.Mvc;

namespace studylist.Controllers
{
    [ApiController]
    [Route("api/schedule")]
    public class ScheduleController : ControllerBase 
    {
        private static readonly string[] Subjects = new[]
        {
            "Terminar a leitura do livro Refactoring", "Estudar sobre algoritmos"
        };

        [HttpGet]
        public ActionResult<string[]> Get()
        {
            return Subjects;
        }

    }
}