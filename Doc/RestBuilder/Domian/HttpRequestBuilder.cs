using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestBuilder.Domian
{
    public  class HttpRequestBuilder
    {
        private HttpMethod method;
        public HttpRequestBuilder Get()
        {
            this.method = HttpMethod.Get;
            return this;
        }
        public HttpRequestBuilder Post()
        {
            this.method = HttpMethod.Post;
            return this;
        }

        public HttpRequestBuilder Put()
        {
            this.method = HttpMethod.Put;
            return this;
        }

        public HttpRequestMessage Build(string url) { return null; }
    }
}
