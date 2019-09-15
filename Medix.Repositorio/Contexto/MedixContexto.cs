using JetBrains.Annotations;
using Medix.Dominio.Entidades;
using Medix.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medix.Repositorio.Contexto
{
    public class MedixContexto : DbContext
    {

        public DbSet<Consulta> Consultas { get; set; }

        public MedixContexto( DbContextOptions options) : base(options)
        {
        }

     /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PacienteConfiguracao());
            modelBuilder.ApplyConfiguration(new ConsultaConfiguracao());
            base.OnModelCreating(modelBuilder);
        }*/
    }
}
