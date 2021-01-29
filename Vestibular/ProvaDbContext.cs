using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vestibular.Models;

namespace Vestibular
{
    public class ProvaDbContext : DbContext
    {
        public ProvaDbContext(DbContextOptions<ProvaDbContext> options)
            : base(options) { }

        public DbSet<Prova> Provas { get; set; }

        public DbSet<Questao> Questoes{ get; set; }

        public DbSet<Opcoes> xOpcoes { get; set; }

    }
}
