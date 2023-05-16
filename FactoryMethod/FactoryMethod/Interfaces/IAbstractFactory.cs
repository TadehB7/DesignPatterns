namespace FactoryMethod.Interfaces
{
    public interface IAbstractFactory<out TInterface>
    {
        TInterface Create();
    }
}
