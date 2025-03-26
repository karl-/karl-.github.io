static class Entry
{
    static int Main(string[] args)
    {
        foreach (var path in args)
        {
            if (!File.Exists(path))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"File not found: {path}");
                continue;
            }

            var text = File.ReadAllText(path);
            File.WriteAllText($"{Path.GetFileName(path)}.html", Markdown.ConvertToHtml(text));
        }


        return 0;
    }
}