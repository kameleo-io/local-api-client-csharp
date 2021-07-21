<img src="docs/kameleo-logo.png" width="150" align="right" />

# Kameleo Local API Client
[Kameleo](https://kameleo.io) is a complete and integrated solution for browser fingerprinting protection, and also for easy browser automation using W3C WebDriver. This .NET Standard package provides convenient access to the [Local API](https://app.swaggerhub.com/apis/kameleo-team/kameleo-local-api/2.3) REST interface of the Kameleo Client.


# Features
- Protection from Selenium/WebDriver detection
- Start unlimited number of profiles with different browser fingerprints
- Use authenticated HTTP/SOCKS/SSH proxies in browsers
- Create isolated browsing environments simultaneously
- Use real browser profiles of Chrome, Firefox, Safari and Edge
- Edit, Import or Export browser cookies
- Modify WebRTC parameters
- Modify Geolocation settings
- Modify WebGL fingerprint
- Modify 2D Canvas fingerprint
- Modify Navigator properties
- Modify Screen resolution


# Quickstart Guide

## 1. Install by NuGet
```
Install-Package Kameleo.LocalApiClient
```

## 2. Start the Kameleo.CLI on your computer
```
./Kameleo.CLI.exe email="your@email.com" password="Pa$$w0rd"
```
> Note: _You need [Automation package](https://kameleo.io/pricing) of Kameleo to access the features described below._

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
        }
    }
}
```

# Automate browsers with W3C WebDriver
Kameleo uses a WebDriver compatible server to control the browser. WebDriver is a W3C specification and industry standard which provides a platform and HTTP protocol to interact with a browser.

```csharp
using System;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Kameleo.LocalApiClient;

namespace Kameleo.AutomateBrowsers
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

            // Connect to the running browser instance using WebDriver
            var uri = new Uri($"{KameleoBaseUrl}/webdriver");
            var opts = new ChromeOptions();
            opts.AddAdditionalOption("kameleo:profileId", profile.Id.ToString());
            var webdriver = new RemoteWebDriver(uri, opts);


            // Use any WebDriver command to drive the browser
            // and enjoy full protection from Selenium detection methods
            webdriver.Navigate().GoToUrl("https://google.com");
            webdriver.FindElement(By.Name("q")).SendKeys("Kameleo");
            webdriver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            await Task.Delay(5000);
            var title = webdriver.Title;
            Console.WriteLine("The title is " + title);

            // Stop the browser by stopping the Kameleo profile
            await client.StopProfileAsync(profile.Id);
        }
    }
}
```

# Example codes
Several [examples](https://github.com/kameleo-io/local-api-examples) have been prepared in a different repository to showcase the most interesting features. Feel free to create a pull request to add new example codes.

- Finding base profiles
- Creating profiles with custom options
- Updating profiles with new settings
- How to start a profile
- Using WebDriver with Local API
- Adding an HTTP, SOCKS or SSH proxy to profile
- Saving/Loading a browsing session to/from a .kameleo file
- Modify and Delete browser cookies
- Hooking up Kameleo with an external browser (Puppeteer)
- Start profile with extra WebDriver capabilites


# Endpoints
Available API endpoints with exhaustive descriptions and example values are documented on this [SwaggerHub](https://app.swaggerhub.com/apis/kameleo-team/kameleo-local-api/2.0) page.


# License
This project is released under MIT License. Please refer the LICENSE.txt for more details.
