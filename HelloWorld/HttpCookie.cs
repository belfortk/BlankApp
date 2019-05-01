﻿using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
        }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];

            }
            set
            {
                _dictionary[key] = value;

            }
        }
    }
}
