<img src="docs/kameleo-logo.png" width="150" align="right" />

# Kameleo Local API Client
With [Kameleo](https://kameleo.io), you can easily create multiple virtual browser profiles to work with multiple accounts. It helps you hide your actual timezone, geolocation, language, IP address and creates natural browser fingerprints to prevent detection by anti-bot systems. Kameleo is compatible with [Selenium](https://www.selenium.dev/), [Playwright](https://playwright.dev/), and [Puppeteer](https://pptr.dev/) frameworks for automating web scraping tasks. This .NET Standard package provides convenient access to the [Local API](https://app.swaggerhub.com/apis/kameleo-team/kameleo-local-api/) REST interface of the Kameleo Client.  See the [article](https://help.kameleo.io/hc/en-us/articles/4418166326417) in our knowledge base for Getting Started with Kameleo Automation.


# Features
- Stay completely undetected, so websites won't be able to detect that you are using automation tools
- Start unlimited number of profiles with different natural browser fingerprints
- Use authenticated HTTP/SOCKS/SSH proxies in browsers
- Create isolated browsing environments simultaneously
- Use real browser profiles of Chrome, Firefox, Safari and Edge
- Edit, Import or Export browser cookies
- Modify WebRTC parameters
- Modify Geolocation settings
- Modify Timezone and Language settings
- Modify WebGL fingerprint
- Modify 2D Canvas fingerprint
- Modify Navigator properties
- Modify Screen resolution

> Note: _You need [Automation package](https://kameleo.io/learn-more/automation/) of Kameleo to access the features described below._


# Quickstart Guide

## 1. Install by NuGet
```
Install-Package Kameleo.LocalApiClient
```

## 2. Start the Kameleo.CLI on your computer
```
./Kameleo.CLI.exe email="your@email.com" password="Pa$$w0rd"
```

## 3. Start a browser with out-of-the-box fingerprinting protection 
```csharp
using System;
using System.Threading.Tasks;
using Kameleo.LocalApiClient;

namespace Kameleo.QuickstartGuide
{
    class Program
    {
        private const string KameleoBaseUrl = "http://localhost:5050";

        static async Task Main()
        {
            var client = new KameleoLocalApiClient(new Uri(KameleoBaseUrl));
            client.SetRetryPolicy(null);

            // Search Chrome Base Profiles
            var baseProfiles = await client.SearchBaseProfilesAsync(deviceType: "desktop", browserProduct: "chrome");

            // Create a new profile with recommended settings
            // for browser fingerprint protection
            var requestBody = BuilderForCreateProfile
                .ForBaseProfile(baseProfiles[0].Id)
                .SetRecommendedDefaults()
                .Build();

            var profile = await client.CreateProfileAsync(requestBody);

            // Start the browser
            await client.StartProfileAsync(profile.Id);

            // At this point you can automate the browser with your favorite framework
        }
    }
}
```

# Automate Kameleo profiles with Selenium
Kameleo gives you the ability to control any supported browser using Selenium. It uses the WebDriver protocol, a W3C specification, and industry-standard to interact with a browser.

You need to install the official [Selenium package](https://www.nuget.org/packages/Selenium.WebDriver/).
```csharp
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
```

```csharp
// Connect to the running browser instance using WebDriver
var uri = new Uri($"http://localhost:{KameleoPort}/webdriver");
var opts = new ChromeOptions();
opts.AddAdditionalOption("kameleo:profileId", profile.Id.ToString());
var webdriver = new RemoteWebDriver(uri, opts);


// Use any WebDriver command to drive the browser
// and enjoy full protection from bot detection products
webdriver.Navigate().GoToUrl("https://google.com");
```

The full example can be found [here](https://github.com/kameleo-io/local-api-examples/blob/master/dotnet-csharp/connect_to_selenium/Program.cs).

# Automate Kameleo profiles with Puppeteer (Chromium-based)
Kameleo lets you control Chromium-based browsers (sorry Firefox fans) using the [Puppeteer.Sharp package](https://www.nuget.org/packages/PuppeteerSharp/). In this simple example you can see how to connect to the browser that Kameleo starts.

You need to import the [Puppeteer.Sharp](https://www.nuget.org/packages/PuppeteerSharp/).

```csharp
using PuppeteerSharp;
```

```csharp
// Connect to the browser through CDP
var browserWsEndpoint = $"ws://localhost:{KameleoPort}/puppeteer/{profile.Id}";
var browser = await Puppeteer.ConnectAsync(new ConnectOptions { BrowserWSEndpoint = browserWsEndpoint, DefaultViewport = null });
var page = await browser.NewPageAsync();

// Use any Puppeteer command to drive the browser
// and enjoy full protection from bot detection products
await page.GoToAsync("https://google.com");
```

The full example can be found [here](https://github.com/kameleo-io/local-api-examples/blob/master/dotnet-csharp/connect_with_puppeteer/Program.cs).

# Automate Kameleo profiles with Playwright
Kameleo allows you to control the browser with the official [Playwright package](https://www.nuget.org/packages/Microsoft.Playwright/). It works little bit different with Chromium-based browsers and Firefox, so we provide an example for both. Here we showcase how you can connect to the browser that is already started by Kameleo.

You need to import the official [Playwright package](https://www.nuget.org/packages/Microsoft.Playwright/).

```csharp
using Microsoft.Playwright;
```

## Chromium-based profiles with Playwright

```csharp
// Connect to the browser with Playwright through CDP
var browserWsEndpoint = $"ws://localhost:{KameleoPort}/playwright/{profile.Id}";
var playwright = await Playwright.CreateAsync();
var browser = await playwright.Chromium.ConnectOverCDPAsync(browserWsEndpoint);

// It is recommended to work on the default context.
// NOTE: We DO NOT recommend using multiple browser contexts, as this might interfere
//       with Kameleo's browser fingerprint modification features.
var context = browser.Contexts[0];
var page = await context.NewPageAsync();

// Use any Playwright command to drive the browser
// and enjoy full protection from bot detection products
await page.GotoAsync("https://google.com");
```

The full example can be found [here](https://github.com/kameleo-io/local-api-examples/blob/master/dotnet-csharp/connect_with_playwright_to_chrome/Program.cs).

## Firefox-based profiles with Playwright

```csharp
// Connect to the browser with Playwright
var browserWsEndpoint = $"ws://localhost:{KameleoPort}/playwright/{profile.Id}";
var playwright = await Playwright.CreateAsync();
var browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
{
    // The Playwright framework is not designed to connect to already running 
    // browsers. To overcome this limitation, a tool bundled with Kameleo, named 
    // pw-bridge.exe will bridge the communication gap between the running Firefox 
    // instance and this playwright script.
    ExecutablePath = "<PATH_TO_KAMELEO_FOLDER>\\pw-bridge.exe",
    Args = new List<string> { $"-target {browserWsEndpoint}" },
});

// Kameleo will open the a new page in the default browser context.
// NOTE: We DO NOT recommend using multiple browser contexts, as this might interfere 
//       with Kameleo's browser fingerprint modification features.
var page = await browser.NewPageAsync();

// Use any Playwright command to drive the browser
// and enjoy full protection from bot detection products
await page.GotoAsync("https://google.com");
```

The full example can be found [here](https://github.com/kameleo-io/local-api-examples/blob/master/dotnet-csharp/connect_with_playwright_to_firefox/Program.cs).

# Example codes
[Several examples](https://github.com/kameleo-io/local-api-examples) have been prepared in a different repository to showcase the most interesting features. Feel free to create a pull request to add new example codes.

- Finding base profiles
- Creating profiles with custom options
- Updating profiles with new settings
- How to start a profile
- Using Selenium with Local API
- Using Playwright with Kameleo
- Using Puppeteer with Kameleo
- Adding an HTTP, SOCKS or SSH proxy to profile
- Saving/Loading a browsing session to/from a .kameleo file
- Modify and Delete browser cookies
- Start profile with extra WebDriver capabilities

> Note: _If you are interested in more information about Kameleo, or have encountered an issue with using it, please check out our [Help Center](https://help.kameleo.io/)._


# License
This project is released under MIT License. Please refer the LICENSE.txt for more details.
