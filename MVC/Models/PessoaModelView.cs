using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class PessoaModelView
    {
        [Required]
        public string Nome { get; set; }
        public string SobreNome { get; set; }
    }
}
