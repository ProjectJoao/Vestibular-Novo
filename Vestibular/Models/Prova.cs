using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vestibular.Models
{
    public class Prova
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        
        public ICollection<Questao> Questoes { get; set; }
    }
}
