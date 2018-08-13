namespace NTier.Core.Core.Entity
{
    public interface IEntity<T>
    {
        T ID { get; set; }
    }
}