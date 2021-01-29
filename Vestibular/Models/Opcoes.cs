using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vestibular.Models
{
    public class Opcoes
    {
        public int Id { get; set; }

        public int NrSequencia { get; set; }

        public string DsRespostas { get; set; }

        //FK-Chave Estrangeira

        [ForeignKey("Questao")]
        public int QuestaoId { get; set; }

        public Questao Questao { get; set; }

    }
}
