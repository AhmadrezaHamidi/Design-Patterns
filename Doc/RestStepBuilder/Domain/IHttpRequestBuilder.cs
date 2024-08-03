using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestStepBuilder.Domain
{

    public interface IHttpRequestBuilder
    {
        HttpRequestMessage build();
    
    }

    internal interface IHttpRequestMethodBuilder
    {
        IHttpRequestBuilder Get();
        IHttpRequestContebtBuilder Put();
        IHttpRequestContebtBuilder Post();
    }

    public interface IHttpRequestContebtBuilder
    {
        IHttpRequestContebtBuilder WithBody(string body);
    }

    public class HttpRequestBuilder
    {

    }

}
