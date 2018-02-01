using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace GreenFoxStore.IntegrationTests
{
    public class ShopTests
    {
        private TestServer server;
        private HttpClient client;

        public ShopTests()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task QueryShouldReturnNotOkStatus()
        {
            var response = await client.GetAsync("/warehouse/query");

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task QueryShouldReturnOkStatus()
        {
            var response = await client.GetAsync("/warehouse/query?price=80&type=higher");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
