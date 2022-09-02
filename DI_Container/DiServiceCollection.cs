namespace DI_Container
{
    public class DiServiceCollection
    {
        private List<ServiceDescriptor> _serviceDescriptors= new List<ServiceDescriptor>();

        public DiContainer GenerateContainer()
        {
            return new DiContainer(_serviceDescriptors);
        }

        //public void RegisterSingleton<TService>()
        //{
        //    _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Singleton));
        //}
        //public void RegisterTransient<TService>()
        //{
        //    _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Transient));
        //}
        public void RegisterSingleton<TService, TImplementation>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
        }

        public void RegisterTransient<TService,TImplementation>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Transient));
        }
    }
}