using System.Threading.Tasks;
using LinqToDB.AspNet;
using Microsoft.Extensions.Hosting;
using Xunit;

namespace Sample.Tests
{
    public class ProductSpec
    {
        [Fact]
        public async Task Test1()
        {
            var host = Host.CreateDefaultBuilder()
                           .ConfigureServices(services =>
                           {
                               services.AddLinqToDbContext((provider, options) =>
                               {

                               })
                           })
        }
    
    }
}
