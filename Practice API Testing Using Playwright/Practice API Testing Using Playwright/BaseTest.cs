using Microsoft.Playwright;
namespace Practice_API_Testing_Using_Playwright
{
    public class BaseTest : IAsyncLifetime
    {
        private IPlaywright playwright;
        private IPage page;
        private IBrowser browser;
        private HttpClient httpClient;

        // This Setup is run before each test
        public async Task InitializeAsync()
        {
            // Initialize Playwright and Launch the Browser
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            page = await browser.NewPageAsync();
            httpClient = new HttpClient(); // Http Client to make an api request
        }

        public async Task DisposeAsync()
        {
            await page.CloseAsync();
            await browser.CloseAsync();
            playwright.Dispose();
        }
    }
}