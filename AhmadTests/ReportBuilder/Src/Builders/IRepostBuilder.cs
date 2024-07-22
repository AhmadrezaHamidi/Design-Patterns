namespace ReportBuilder.Src.Builders
{
    public interface IRepostBuilder
    {
        public void AddTitle(string title);
        public void AddDescription(string description);
        public void AddAuthor(string author);
        Document Build();
    }
    public class HtmlReportBulder : IRepostBuilder
    {
        private readonly HtmlDocument _document;
        public HtmlReportBulder()
        {
            _document = new HtmlDocument();
        }

        public void AddAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public void AddDescription(string description)
        {
            throw new NotImplementedException();
        }

        public void AddTitle(string title) { }

        public Document Build()
        {
            return new HtmlDocument();
        }
    }
}
