using Microsoft.AspNetCore.Mvc;
using ProjetoAula.Services;
using ProjetoAula.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAula.Controllers
{
    public class LivroController : Controller
    {
        private readonly LivroService _livroService = new LivroService();
        
        public IActionResult Index()
        {
            var list = _livroService.GetLivros();

            return View(list);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LivroDto model)
        {
            try
            {
                _livroService.SalvarLivro(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return View();
        }

        public IActionResult Update(int id)
        {
            try
            {
                var livro = _livroService.GetById(id);
                return View(livro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Update(LivroDto model)
        {
            try
            {
                _livroService.SalvarLivro(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return View();
        }
    }
}
