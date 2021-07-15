using Microsoft.AspNetCore.Mvc;
using SalvarPessoa.Models;
using System;

namespace SalvarPessoa.Controllers
{
    [Route("/pessoas")]
    public class PessoaController : Controller
    {
        [HttpPost]
        public void SalvarPessoa(Pessoa pessoa)
        {
            Console.WriteLine(pessoa);
            // this.salvarNoBancoDeDados(pessoa);
        }
    }
}
