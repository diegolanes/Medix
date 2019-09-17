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
            if ((DataInicioConsulta.TimeOfDay < DateTime.Now.TimeOfDay) || (DataFimConsulta.TimeOfDay < DateTime.Now.TimeOfDay))
            {
                AdicionaMensagem("Consulta deve ser marcada em um horário maior que o atual");
            }
            if (DataFimConsulta < DataInicioConsulta)
            {
                AdicionaMensagem("A data do final da consulta nao pode ser menor que a data de inicio");
            }

            if (String.IsNullOrEmpty(NomePaciente))
            {
                AdicionaMensagem("Nome do Paciente nao pode ser vazio");
            }
        }

        public override void RegraDeNegocio(IEnumerable<Consulta> consultas, Consulta consulta)
        {

            foreach (var c in consultas)
            {
                if (c.DataInicioConsulta.TimeOfDay == consulta.DataInicioConsulta.TimeOfDay)
                {
                    AdicionaMensagem("Consultas nao podem ser marcadas no mesmo horário");
                }             

            }

        }


    }
}
