using System.Collections.Generic;
using System.Linq;
using FuncionariosAPI.Domain.Entities;
using FuncionariosAPI.Domain.Models;

namespace Infra.Shared.Mapper
{
    public static class FuncionarioMapper
    {
        public static Funcionario ConvertToUserEntity(this CreateFuncionarioModel userModel) =>
            new Funcionario(0, userModel.Nome, userModel.GerenteId);

        public static Funcionario ConvertToUserEntity(this UpdateFuncionarioModel userModel) =>
            new Funcionario(userModel.Id, userModel.Nome, userModel.GerenteId);

        public static IEnumerable<FuncionarioModel> ConvertToUsers(this IList<Funcionario> users) =>
            new List<FuncionarioModel>(users.Select(s => new FuncionarioModel(s.Id, s.Nome, s.GerenteId)));

        public static FuncionarioModel ConvertToUser(this Funcionario user) =>
            new FuncionarioModel(user.Id, user.Nome, user.GerenteId);
    }
}
