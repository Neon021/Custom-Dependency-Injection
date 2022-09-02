using System.Security.Cryptography;
using System.Transactions;

namespace DI_Container
{
    class DI_Container
    {
        static void Main(string[] args)
        {
            var services = new DiServiceCollection();

            //services.RegisterTransient<RandomGuidGenerator>();
            //services.RegisterTransient<RandomGuidGenerator>();
            
            services.RegisterTransient<IRandomGuidGenerator, RandomGuidGenerator>();
            services.RegisterTransient<ISomeService, SomeService>();

            var container = services.GenerateContainer();

            var firstService = container.GetService<ISomeService>();
            var secondService = container.GetService<ISomeService>();

            firstService.DoSmthng();
            secondService.DoSmthng();
        }
    }
}