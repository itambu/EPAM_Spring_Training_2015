using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public struct Symbol
    {
        private string chars;

        public string Chars
        {
            get { return chars; }
            private set { chars = value; }
        }

        public Symbol(string chars)
        {
            this.chars = chars;
        }

        public Symbol(char source)
        {
            this.chars = String.Format("{0}", source);
        }

        public bool IsUppercase
        {
            get { return chars != null && chars.Length >= 1 && char.IsLetter(chars[0]) && char.IsUpper(chars[0]); }
        }

        public bool IsLower 
        { 
            get { return chars != null && chars.Length >= 1 && char.IsLetter(chars[0]) && char.IsLower(chars[0]); } 
        }
    }
}
