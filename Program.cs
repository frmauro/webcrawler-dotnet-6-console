using PuppeteerSharp;
using AngleSharp;

using var browserFetcher = new BrowserFetcher();

await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
var browser = await Puppeteer.LaunchAsync(new LaunchOptions
{
    Headless = true
});

var page = await browser.NewPageAsync();
await page.GoToAsync("https://www.scrapethissite.com/pages/simple/");
var content = await page.GetContentAsync();


var context = BrowsingContext.New(Configuration.Default);
var document = await context.OpenAsync(req => req.Content(content));

//Console.WriteLine(content);
