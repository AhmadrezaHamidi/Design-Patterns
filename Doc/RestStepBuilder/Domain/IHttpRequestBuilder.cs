using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestStepBuilder.Domain
{

    public interface IHttpRequestBuilder
    {
        IHttpRequestBuilder Url(string url);
        HttpRequestMessage build();
    }

    public interface IHttpRequestMethodBuilder
    {
        IHttpRequestBuilder Get();
        IHttpRequestContentBuilder Put();
        IHttpRequestContentBuilder Post();
    }

    public interface IHttpRequestContentBuilder
    {
        IHttpRequestBuilder WithBody(string body);
    }

    public static class HttpRequestFactory
    {
        public static IHttpRequestBuilder MakeRequest()
        {
            return new HttpRequestBuilder();
        }
    }
    internal class HttpRequestBuilder : IHttpRequestBuilder, IHttpRequestMethodBuilder, IHttpRequestContentBuilder
    {
        private string _url = string.Empty;
        private string _content = string.Empty;
        private HttpMethod HttpMethod = HttpMethod.Get;

        internal HttpRequestBuilder() { }


        public HttpRequestMessage build()
        {
            throw new NotImplementedException();
        }

        public IHttpRequestBuilder Get()
        {
            this.HttpMethod = HttpMethod.Get;
            return this;
        }

        public IHttpRequestContentBuilder Post()
        {
            this.HttpMethod = HttpMethod.Post;
            return this;
        }

        public IHttpRequestContentBuilder Put()
        {
            this.HttpMethod = HttpMethod.Put;
            return this;
        }

        public IHttpRequestBuilder Url(string url)
        {
            this._url = url;
            return this;
        }


        public IHttpRequestBuilder WithBody(string body)
        {
            throw new NotImplementedException();
        }
    }

}
