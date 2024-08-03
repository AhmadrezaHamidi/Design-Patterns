using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedUrlBuilder.Domain
{
    public class QueryStringBuilder
    {
        private Dictionary<string,string> _paramerters = new Dictionary<string,string>();
        public QueryStringBuilder WithParamerters(string key,string value) {
            _paramerters.Add(key, value);
            return this;
                }
        
        public string Builde()
        {
            var queryString = new StringBuilder();
            queryString.Append(_paramerters.Values);
            return queryString.ToString();
        }
    
    }
}
