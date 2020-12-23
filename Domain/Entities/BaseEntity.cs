namespace FuncionariosAPI.Domain.Entities
{
    public abstract class BaseEntity<TKeyType>
    {
        public BaseEntity(TKeyType id = default)
        {
            Id = id;
        }

        public virtual TKeyType Id { get; }
    }
}