using System.Collections.Generic;

namespace FuncionariosAPI.Domain.Entities
{
    public class Funcionario : BaseEntity<int>
    {
        public Funcionario(int id, string nome, int? gerenteId) : base(id)
        {
            Nome = nome;
            GerenteId = gerenteId;
        }
        public string Nome { get; }

        public virtual IEnumerable<Funcionario> Subordinados { get; }

        #region Foreign Keys
        public int? GerenteId { get; set; }

        public virtual Funcionario Gerente { get; set; }

        #endregion
    }
}