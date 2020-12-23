namespace FuncionariosAPI.Domain.Models
{
    public class CreateFuncionarioModel
    {
        public string Nome { get; set; }
        public int? GerenteId { get; set; }
    }
}