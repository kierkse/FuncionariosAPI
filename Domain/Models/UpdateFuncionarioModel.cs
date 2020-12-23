namespace FuncionariosAPI.Domain.Models
{
    public class UpdateFuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? GerenteId { get; set; }
    }
}