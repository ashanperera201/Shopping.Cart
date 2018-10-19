#region References
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
#endregion

#region Namespace
namespace Cart.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
#endregion