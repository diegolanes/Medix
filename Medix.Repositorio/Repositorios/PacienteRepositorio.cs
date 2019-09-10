using System;
using System.Collections.Generic;
using System.Text;
using Medix.Dominio.Contratos;
using Medix.Dominio.Entidades;


namespace Medix.Repositorio.Repositorios
{
    class PacienteRepositorio : BaseRepositorio<Paciente>, IPacienteRepositorio
    {

        public PacienteRepositorio()
        {

        }

        public void Adicionar(Paciente entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Paciente entity)
        {
            throw new NotImplementedException();
        }

        public void Remover(Paciente entity)
        {
            throw new NotImplementedException();
        }

        Paciente IBaseRepositorio<Paciente>.ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Paciente> IBaseRepositorio<Paciente>.ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
