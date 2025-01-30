using Microsoft.Playwright;
namespace Practice_API_Testing_Using_Playwright
{
    public class BaseTest : IAsyncLifetime
    {
        protected IPlaywright Playwright;
        protected IPage Page;
        protected IBrowser Browser;
        protected HttpClient HttpClient;
        

        // This Setup is run before each test
        public async Task InitializeAsync()
        {
            // Initialize Playwright and Launch the Browser
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            Page = await Browser.NewPageAsync();
            HttpClient = new HttpClient(); // Http Client to make an api request
        }

        public async Task DisposeAsync()
        {
            await Page.CloseAsync();
            await Browser.CloseAsync();
            Playwright.Dispose();
        }
    }
}