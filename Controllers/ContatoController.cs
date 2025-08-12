using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCASPNET.Context;
using MVCASPNET.Models;

namespace MVCASPNET.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contatos = _context.Constatos.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Constatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(contato);
        }

        public IActionResult Editar(int id)
        {
            var contato = _context.Constatos.Find(id);

            if (contato == null)
                return NotFound();

            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var contatoBanco = _context.Constatos.Find(contato.Id);

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Constatos.Update(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var contato = _context.Constatos.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        public IActionResult Deletar(int id)
        {
            var contato = _context.Constatos.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _context.Constatos.Find(contato.Id);

            _context.Constatos.Remove(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}