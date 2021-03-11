using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace ServiceOptionsSample
{
    public class ConfigureMySettings : IConfigureOptions<MyOptions>
    {
        // Inject the IoC provider
        private readonly IServiceProvider _provider;

        // Directly inject the Scoped service
        private readonly ValueService _service;
        public ConfigureMySettings(IServiceProvider provider)
        {
            _provider = provider;
        }

        public void Configure(MyOptions options)
        {
            // Create a new scope
            using (var scope = _provider.CreateScope())
            {
                // Use the scoped service to set the value
                var service = scope.ServiceProvider.GetService<ValueService>();
                options.Option1 = service.GetValue().ToString();
            }
        }
    }
}