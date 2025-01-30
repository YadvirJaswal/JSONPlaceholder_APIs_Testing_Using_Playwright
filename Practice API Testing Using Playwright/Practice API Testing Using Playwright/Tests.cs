using Practice_API_Testing_Using_Playwright.Models;
using System.Text.Json;

namespace Practice_API_Testing_Using_Playwright
{
    public class Tests : BaseTest
    {
        private string url;
        public Tests()
        {
            url = "https://jsonplaceholder.typicode.com/posts";
        }
        // Validate the "Get All Posts" Api Request
        [Fact]
        public async Task TestsGetAllPosts()
        {
            // Make get request to fetch all posts from JSONplaceholder
            var response = await HttpClient.GetAsync(url);

            // Assert the status code
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);

            // Read the response body as the string
            var content = await response.Content.ReadAsStringAsync();

            Assert.Contains("\"userId\":",content); //Assert that the response body has userId
            Assert.Contains("\"title\":", content); //Assert that the response body has Title
            Assert.Contains("\"body\":", content); //Assert that the response body has Body
            Assert.Contains("\"id\":", content); //Assert that the response body has id

        }

        // Validate the "Get Post By Id" request
        [Fact]
        public async Task TestGetPostById()
        {
            // Make get request to fetch post by Id from JSONplaceholder
            var response = await HttpClient.GetAsync($"{url}/1");

            // Assert status code 200 ok
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);

            // Read the response body as the string
            var responseBody = await response.Content.ReadAsStringAsync();

            // Deserialize JSON with options
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // Parse JSON response
            var jsonResponse = JsonSerializer.Deserialize<PostsModel>(responseBody,options);

            Assert.NotNull(jsonResponse); // Ensure response is not null
            Assert.Equal(1, jsonResponse.Id); // Assert the 'id' value matches the expected value
        }
    }
}
