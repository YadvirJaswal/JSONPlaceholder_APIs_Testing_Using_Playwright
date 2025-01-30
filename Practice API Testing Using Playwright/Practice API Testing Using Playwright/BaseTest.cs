using Microsoft.Playwright;
namespace Practice_API_Testing_Using_Playwright
{
    public class BaseTest : IAsyncLifetime
    {
        protected IPlaywright Playwright;
        protected IPage Page;
        protected IBrowser Browser;
        protected IAPIRequestContext RequestContext;
        protected HttpClient HttpClient;
        

        // This Setup is run before each test
        public async Task InitializeAsync()
        {
            // Initialize Playwright and Launch the Browser
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            Browser = await Playwright.Chromium.LaunchAsync();
            //Page = await Browser.NewPageAsync();
            RequestContext = await Playwright.APIRequest.NewContextAsync(new APIRequestNewContextOptions
            {
                BaseURL = "https://jsonplaceholder.typicode.com"
            });
            HttpClient = new HttpClient(); // Http Client to make an api request
        }

        public async Task DisposeAsync()
        {
            //await Page.CloseAsync();
            //await Browser.CloseAsync();
            //Playwright.Dispose();
            await RequestContext.DisposeAsync();
        }
    }
}