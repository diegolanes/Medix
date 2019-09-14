using Medix.Dominio.Contratos;
using Medix.Dominio.Entidades;
using Medix.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medix.Repositorio.Repositorios
{
    public class ConsultaRepositorio : BaseRepositorio<Consulta>, IConsultaRepositorio
    {
        public ConsultaRepositorio(MedixContexto medixContexto) : base(medixContexto)
        {

        }

    }
}
