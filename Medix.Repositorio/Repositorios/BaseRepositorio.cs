using Medix.Dominio.Contratos;
using Medix.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Medix.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly MedixContexto MedixContexto;

        public BaseRepositorio()
        {

        }

        public BaseRepositorio(MedixContexto medixContexto)
        {
            MedixContexto = medixContexto;
        }


        public void Adicionar(TEntity entity)
        {
            MedixContexto.Set<TEntity>().Add(entity);
            MedixContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            MedixContexto.Set<TEntity>().Update(entity);
            MedixContexto.SaveChanges();
        }

        public void Dispose()
        {
            MedixContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return MedixContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return MedixContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            MedixContexto.Remove(entity);
            MedixContexto.SaveChanges();
        }
    }
}
