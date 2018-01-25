using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IAmGroot.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient client;
        private TestServer server;

        public GuardianTests()
        {
            //arrange
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task GrootShouldReturnNotOkStatus()
        {
            //act
            var response = await client.GetAsync("/groot");

            //assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task GrootWithParameterShouldReturnOkStatus()
        {
            //act
            var response = await client.GetAsync("/groot?message=somemessage");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task YonduShouldReturnNotOkStatus()
        {
            //act
            var response = await client.GetAsync("/yondu");

            //assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task YonduWithParameterShouldReturnOkStatus()
        {
            //act
            var response = await client.GetAsync("/yondu?distance=100&&time=20");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
    
}
