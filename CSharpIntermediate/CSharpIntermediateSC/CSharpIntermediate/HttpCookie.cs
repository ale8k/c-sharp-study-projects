using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public Dictionary<string, string> test = new Dictionary<string, string>();

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
