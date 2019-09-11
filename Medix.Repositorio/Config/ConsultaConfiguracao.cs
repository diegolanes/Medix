using Medix.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medix.Repositorio.Config
{
    public class ConsultaConfiguracao : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                    .Property(c => c.DataInicioConsulta)
                    .IsRequired()
                    .HasColumnType("smalldatetime");

            builder
                    .Property(c => c.DataFimConsulta)
                    .IsRequired()
                    .HasColumnType("smalldatetime");

            builder
                    .Property(c => c.PacienteId)
                    .IsRequired()
                    .HasColumnType("bigint");
        }
    }
}
