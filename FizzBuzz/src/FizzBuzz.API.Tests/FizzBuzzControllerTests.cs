using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace FizzBuzz.API.Tests
{
    public class FizzBuzzControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        public FizzBuzzControllerTests(WebApplicationFactory<Startup> fixture)
        {
            Client = fixture.CreateClient();
        }

        public HttpClient Client { get; }

        [Fact]
        public async void When_GetFizzBuzz_Expect_ResponseShouldBeSuccessStatusCode()
        {
            var result = await Client.GetAsync(@"/FizzBuzz/5");
            
            Assert.True(result.IsSuccessStatusCode);
        }

        [Fact]
        public async void When_GetFizzBuzzWithDivisibleBy5_Expect_ResponseBodyShouldEndWithBuzz()
        {
            var result = await Client.GetAsync(@"/FizzBuzz/5");

            var body = await result.Content.ReadAsStringAsync();
            Assert.EndsWith("BUZZ", body);
        }
    }
}
