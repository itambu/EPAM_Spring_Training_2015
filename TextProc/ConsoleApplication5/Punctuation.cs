using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class Punctuation : IPunctuation
    {
        private Symbol value;
        public Symbol Value
        {
            get { return this.value; }
        }

        public string Chars
        {
            get { return this.Value.Chars; }
        }

        public Punctuation(string chars)
        {
            this.value = new Symbol(chars);
        }
    }
}
