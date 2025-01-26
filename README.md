# Rise Quotes
 The source code to [Rise Quotes](https://x.com/rise_quotes) on Twitter

# Setup
 Make a login.txt in the main directory file and fill it in this manner
```bash
username
password
```
 not the most secure ik but idrc; it works for me

# Dependencies
 You can find the source of the cli-bot thing at [cli-bot-lib](https://github.com/DogeDoge17/cli-bot-lib)\
 You can find the Quill.dll file inside that repo too as its required\
 You also need [Newtonsoft.Json](https://www.nuget.org/packages/newtonsoft.json/), [Selenium](https://www.nuget.org/packages/selenium.webdriver), and [WaitHelpers](https://www.nuget.org/packages/SeleniumExtras.WaitHelpers) as Quill.dll depends on them

# cli-bot-lib
 Again, this repo does not include most of the code that runs the management of the bot, but only what will be tweeted. All that code can be found in [cli-bot-lib](https://github.com/DogeDoge17/cli-bot-lib). Please refer to that if you want to see more of the innerworkings of the bot. (minus the actual bits that webscrape as thats handled by Quill, which isnt open source yet)

# Quill.dll
 This is the backend of the twitter webscraper i use and wrote. Source code and github page is coming soon but unfortunately, as of right now, you will just have to download the dll [here](https://github.com/DogeDoge17/cli-bot-lib/blob/main/Quill.dll).\
 I have a rough but similar implementation to how i webscrape but with [Playwright](https://playwright.dev/dotnet/) inside of my old source code for [Adachi Reaction](https://github.com/DogeDoge17/adachi-reaction-bot-open/) which can be found [here](https://github.com/DogeDoge17/adachi-reaction-bot-open/blob/master/Form1.cs#L181). Please keep in mind that Playwright is not multiplatform but the idea of what Quill and this does is roughly the same.
