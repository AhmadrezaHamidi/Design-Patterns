namespace ReportBuilder.Src.Builders
{
    public class Document
    {
      public string Id { get; set; }
    }

    public class HtmlDocument : Document { }

    public class XmlDocument : Document { }
}
