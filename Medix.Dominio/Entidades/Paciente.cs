using System;
using System.Collections.Generic;
using System.Text;

namespace Medix.Dominio.Entidades
{
    class Paciente : Entidade
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public override void Validate()
        {         
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionaMensagem("Nome do paciente nao pode ser vazio");
            }
        }
    }
}
