using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vestibular.Models
{
    public class Questao
    {
        [Key]

        public int Id { get; set; }

        public int NrSequencia { get; set; }

        public String DsQuestao { get; set; }

        public int Peso { get; set; }

        //FK- Chave Estrangeira
        [ForeignKey("Prova")]
        public int ProvaId { get; set; }

        public Prova Prova { get; set; }


    }
}
