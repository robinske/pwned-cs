using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PwnedPasswords.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace pwnedPasswords
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
            ConfigureServices(services);

            var provider = services.BuildServiceProvider();

            var app = provider.GetService<Application>();
            await app.Verify("password1");

        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<Application>();
            services.AddLogging();
            services.AddPwnedPasswordHttpClient();                      // add the client to the container
        }
    }

    public class Application
    {
        IPwnedPasswordsClient _client;

        public Application(IPwnedPasswordsClient client)
        {
            _client = client;
        }

        public async Task Verify(string password)
        {
            var result = await _client.HasPasswordBeenPwned(password);
            Console.WriteLine(result);
        }
    }
}
