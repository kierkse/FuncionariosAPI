using System.Collections.Generic;
using FuncionariosAPI.Domain.Interfaces;
using FuncionariosAPI.Domain.Models;
using Infra.Shared.Mapper;

namespace FuncionariosAPI.Services
{
    public class FuncionarioService : IServiceFuncionario
    {
        private readonly IRepositoryFuncionario _repositoryUser;
        public FuncionarioService(IRepositoryFuncionario repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }
        public FuncionarioModel Insert(CreateFuncionarioModel userModel)
        {
            var user = userModel.ConvertToUserEntity();
            _repositoryUser.Save(user);
            return user.ConvertToUser();
        }

        public FuncionarioModel Update(int id, UpdateFuncionarioModel userModel)
        {
            var user = userModel.ConvertToUserEntity();
            _repositoryUser.Save(user);
            return user.ConvertToUser();
        }

        public void Delete(int id)
        {
            _repositoryUser.Remove(id);
        }

        public FuncionarioModel RecoverById(int id)
        {
            var user = _repositoryUser.GetById(id);
            return user.ConvertToUser();
        }

        public IEnumerable<FuncionarioModel> RecoverAll()
        {
            var users = _repositoryUser.GetAll();
            return users.ConvertToUsers();
        }
    }
}