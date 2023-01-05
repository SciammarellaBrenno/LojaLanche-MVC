using CursoUdemy.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CursoUdemy.Controllers
{
    public class LancheController : Controller
    {
        protected readonly ILancheRepository _repository;

        public LancheController(ILancheRepository repository)
        {
            _repository = repository;
        }

        public IActionResult List()
        {
            var lanches = _repository.GetAll();
            return View(lanches);
        }
    }
}
