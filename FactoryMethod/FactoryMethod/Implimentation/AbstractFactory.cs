using FactoryMethod.Interfaces;

namespace FactoryMethod.Implimentation
{
    public class AbstractFactory<TInterface> : IAbstractFactory<TInterface> where TInterface : class
    {
        private readonly Func<TInterface> _factory;

        public AbstractFactory(Func<TInterface> factory)
        {
            _factory = factory;
        }
        public TInterface Create()
        {
            return _factory();
        }
    }
}
