using System.Collections.Generic;
using FuncionariosAPI.Domain.Entities;

namespace FuncionariosAPI.Domain.Interfaces
{
    public interface IRepositoryFuncionario
    {
        void Save(Funcionario obj);
        void Remove(int id);
        Funcionario GetById(int id);
        IList<Funcionario> GetAll();
    }
}