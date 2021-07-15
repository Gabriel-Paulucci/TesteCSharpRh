using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SalvarPessoa.Models;

namespace SalvarPessoa.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Pessoa Pessoa { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Pessoa = new Pessoa();
        }

        public void OnGet()
        {

        }
    }
}
