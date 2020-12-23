using System.Collections.Generic;
using FuncionariosAPI.Domain.Models;

namespace FuncionariosAPI.Domain.Interfaces
{
    public interface IServiceFuncionario
    {
        FuncionarioModel Insert(CreateFuncionarioModel userModel);

        FuncionarioModel Update(int id, UpdateFuncionarioModel userModel);

        void Delete(int id);

        FuncionarioModel RecoverById(int id);

        IEnumerable<FuncionarioModel> RecoverAll();
    }
}