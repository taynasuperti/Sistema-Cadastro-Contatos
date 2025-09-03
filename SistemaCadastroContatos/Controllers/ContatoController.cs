using Microsoft.AspNetCore.Mvc;
using SistemaCadastroContatos.Models;
using SistemaCadastroContatos.Repositorio;

namespace SistemaCadastroContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = _contatoRepositorio;
        }
        //todos aqui são métodos GET (metodos para busca)
        public IActionResult Index()
        {
            List<ContatoModel> contatos =  _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        //todos aqui são métodos POST (metodos para receber e cadastrar dados)
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");   
        }
    }
}
