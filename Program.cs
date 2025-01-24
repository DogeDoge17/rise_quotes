using cli_bot;
using Quill.Pages;
using Path = cli_bot.Path;

Console.WriteLine(Path.Assembly / "quotes.txt");
string[] words = File.OpenText(Path.Assembly / "quotes.txt").ReadToEnd().Split('|', StringSplitOptions.RemoveEmptyEntries).Select(wr => wr.Trim().Replace("\\n", "\n")).ToArray();

TwitterBot rise = new(TimeSpan.FromMinutes(60)) { DisplayName = "Rise Quotes" };

rise.runAction += Run;

rise.Start();

void Run(ComposePage composer, string[] args)
{
    try
    {
        var word = words[Random.Shared.Next(0, words.Length)];
        Output.WriteLine($"Tweeting \"{word}\"");
        composer.Tweet(word);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}