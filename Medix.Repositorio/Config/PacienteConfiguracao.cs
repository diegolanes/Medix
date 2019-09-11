using Medix.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medix.Repositorio.Config
{
    public class PacienteConfiguracao : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder
                    .HasKey(p => p.Id);

            builder
                    .Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(250);
            builder
                    .Property(p => p.DataDeNascimento)
                    .HasColumnType("smalldatetime");
                    
        }
    }
}
