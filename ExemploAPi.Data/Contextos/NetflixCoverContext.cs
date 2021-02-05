using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ExemploAPi.Data.Entidades;

namespace ExemploAPi.Data.Contextos
{
    public class NetflixCoverContext : DbContext
    {
        public NetflixCoverContext(DbContextOptions<NetflixCoverContext> opt) : base(opt)
        {
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Serie> Series { get; set; }
    }
}
