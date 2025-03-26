interface IScope
{
    void Open(StringWriter writer);
    void Close(StringWriter writer);
}

class Markdown : IDisposable
{
    StringReader m_Reader;
    Stack<IScope> m_Scope;

    public Markdown(string path) => m_Reader = new StringReader(path);

    public string ConvertToHtml(string path)
    {
        using (var read = new StreamReader(path))
        {

        }
    }

    public void Dispose()
    {
        m_Reader.Dispose();
    }
}