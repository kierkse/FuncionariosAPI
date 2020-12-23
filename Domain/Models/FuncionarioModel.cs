namespace FuncionariosAPI.Domain.Models
{
    public class FuncionarioModel
    {
        public FuncionarioModel(int id, string nome, int? gerenteId)
        {
            Id = id;
            Nome = nome;
            GerenteId = gerenteId;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? GerenteId { get; set; }
    };
}
