using System.Collections.Generic;
using FuncionariosAPI.Domain.Entities;
using FuncionariosAPI.Infra.Data.Context;
using FuncionariosAPI.Domain.Interfaces;

namespace FuncionariosAPI.Infra.Data.Repository
{
    public class FuncionarioRepository : BaseRepository<Funcionario, int>, IRepositoryFuncionario
    {
        public FuncionarioRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }
        public void Save(Funcionario obj)
        {
            if (obj.Id == 0)
            {
                base.Insert(obj);
            }
            else
            {
                base.Update(obj);
            }
        }

        public void Remove(int id)
        {
            base.Delete(id);
        }

        public Funcionario GetById(int id)
        {
            return base.Select(id);
        }

        public IList<Funcionario> GetAll()
        {
            return base.Select();
        }
    }
}