using System;
using System.Collections.Generic;
using System.Text;

namespace Medix.Dominio.Entidades
{
    public class Consulta : Entidade
    {
        public int Id { get; set; }

        public DateTime DataInicioConsulta { get; set; }

        public DateTime DataFimConsulta { get; set; }

        public String NomePaciente { get; set; }

        public DateTime DataNascimentoPaciente { get; set; }

        public override void Validate()
        {
            if (DataInicioConsulta < DateTime.Now)
            {
                AdicionaMensagem("Consulta deve ser marcada em um horário maior que o atual");
            }
        }
    }
}
