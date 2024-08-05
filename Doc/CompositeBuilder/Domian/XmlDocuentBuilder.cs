using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeBuilder.Domian
{
    public class TagNode
    {
        public string Name { get; set; }
        public void Attributes(string key, string value)
        {

        }
    }

    internal class XmlDocuentBuilder
    {
        private TagNode _rootNode;
        private TagNode _currentNode;
        public XmlDocuentBuilder(string rootNode)
        {
            _rootNode = new TagNode();
            _currentNode = new TagNode();
        }
        public XmlDocuentBuilder WithAttributes(string key , string value)
        {
            _rootNode.Attributes(key, value);
            return this;
        }

        public TagNode Build()
        {
            return _rootNode;
        }
    }
}
