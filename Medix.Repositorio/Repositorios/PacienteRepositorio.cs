using System;
using System.Collections.Generic;
using System.Text;
using Medix.Dominio.Contratos;
using Medix.Dominio.Entidades;
using Medix.Repositorio.Contexto;

namespace Medix.Repositorio.Repositorios
{
    public class PacienteRepositorio : BaseRepositorio<Paciente>, IPacienteRepositorio
    {

        public PacienteRepositorio(MedixContexto medixContexto) : base(medixContexto)
        {

        }

    }
}
