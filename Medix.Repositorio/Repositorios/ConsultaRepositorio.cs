using Medix.Dominio.Contratos;
using Medix.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medix.Repositorio.Repositorios
{
    class ConsultaRepositorio : IBaseRepositorio<Consulta>, IConsultaRepositorio
    {
        public void Adicionar(Consulta entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Consulta entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Consulta ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Consulta> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Consulta entity)
        {
            throw new NotImplementedException();
        }
    }
}
