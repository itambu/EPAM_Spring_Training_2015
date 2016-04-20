using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class Word : IWord
    {
        //private string chars;

        private Symbol[] symbols;


        public Word(IEnumerable<Symbol> source)
        {
            symbols = source.ToArray();
        }

        public Word(string chars)
        {
            if (chars != null)
            {
                this.symbols = chars.Select(x => new Symbol(x)).ToArray();
            }
            else
            {
                this.symbols = null;
            }
        }
        
        public Symbol this[int index]
        {
            get { return this.symbols[index]; }
        }

        public string Chars
        {
            get 
            {
                StringBuilder sb = new StringBuilder();
                foreach (var s in this.symbols)
                {
                    sb.Append(s.Chars);
                }
                return sb.ToString(); 
            }
        }

        public IEnumerator<Symbol> GetEnumerator()
        {
            //foreach (var s in symbols)
            //{
            //    yield return s;
            //}

            return symbols.AsEnumerable().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.symbols.GetEnumerator();
        }


        public int Length
        {
            get { return (symbols != null) ? symbols.Length : 0; }
        }
    }
}
