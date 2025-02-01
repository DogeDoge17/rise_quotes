# Rise Quotes
 The source code to [Rise Quotes](https://x.com/rise_quotes) on Twitter

# Setup
 [Build](https://github.com/Doge-Productions/Quill.api/tree/experimental) or [locate Quill.dll](https://github.com/DogeDoge17/cli-bot-lib/blob/main/Quill.dll) and [build](https://github.com/DogeDoge17/cli-bot-lib), and then make project references to both the libraries in the csproj. You may also recursive clone [cli-bot-lib](https://github.com/DogeDoge17/cli-bot-lib) and everything should work from there (granted you don't change the structure).\
 Make a login.txt file in the main directory file and fill it in this manner
```bash
username
password
```
 It's not the most secure method to do this but it'll have to work with me.
# Dependencies
 You can find the source of the cli-bot dll at [cli-bot-lib](https://github.com/DogeDoge17/cli-bot-lib)\
 You can find the Quill.dll file inside the [cli-bot-lib](https://github.com/DogeDoge17/cli-bot-lib) repo as its required or you may compile the binary from [here](https://github.com/Doge-Productions/Quill.api/tree/experimental).\
 You also need [Newtonsoft.Json](https://www.nuget.org/packages/newtonsoft.json/), [Selenium](https://www.nuget.org/packages/selenium.webdriver), and [WaitHelpers](https://www.nuget.org/packages/SeleniumExtras.WaitHelpers) as Quill.dll depends on them.
# cli-bot-lib
 Again, this repo does not include most of the code that runs the management of the bot, but only what will be tweeted. All that code can be found in [cli-bot-lib](https://github.com/DogeDoge17/cli-bot-lib). Please refer to that if you want to see more of the innerworkings of the bot. 
# Quill.dll
  Quill is a library I wrote that streamlines webscraping twitter with the sole purpose of making bots. It's limited in features as its only good for composing tweets but that should be enough to satisfy the needs of most bots. There is no nuget page setup as of right now so the only way to obtain the DLL is by compiling the [experimental branch](https://github.com/Doge-Productions/Quill.api/tree/experimental) or by downloading the precompiled binary from [here](https://github.com/DogeDoge17/cli-bot-lib/blob/main/Quill.dll).