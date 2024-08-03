using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationUrlBuilder.Domian
{

    public class UrlBuilder
    {
        private string _scheme = "https";
        private string _host = "localhost";
        private string _port = string.Empty;
        private Dictionary<string, string> _queryString = new Dictionary<string, string>();
        private string _path = string.Empty;

        public UrlBuilder WithScheme(string scheme)
        {
            _scheme = scheme;
            return this;
        }

        public UrlBuilder WithHost(string host)
        {
            _host = host;
            return this;
        }

        public UrlBuilder WithPort(string port)
        {
            _port = port;
            return this;
        }

        public UrlBuilder WithPath(string path)
        {
            _path = path.TrimStart('/');
            return this;
        }

        public UrlBuilder WithQueryString(string key, string value)
        {
            _queryString[key] = value;
            return this;
        }

        public string Build()
        {
            var builder = new StringBuilder();

            builder.Append($"{_scheme}://");
            builder.Append(_host);

            if (!string.IsNullOrEmpty(_port))
            {
                builder.Append($":{_port}");
            }

            if (!string.IsNullOrEmpty(_path))
            {
                builder.Append($"/{_path}");
            }

            if (_queryString.Any())
            {
                builder.Append("?");
                builder.Append(string.Join("&", _queryString.Select(kvp => $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}")));
            }

            return builder.ToString();
        }
    }
}
