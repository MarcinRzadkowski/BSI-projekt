using System.Linq.Expressions;
using System.Text;

namespace BSI_projekt.Models
{
    public class Cezar
    {
        public int? klucz { get; set; }
        public string? text { get; set; }

        public string zaszyfruj()
        {
            if (text == null)
            {
                return " ";
            }
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
            }

            string output = string.Empty;
            
            foreach (char c in sb.ToString())
            {
                output += szyfr(c, klucz);
            }
            return output;
        }

        public string odszyfruj()
        {
            if (text == null)
            {
                return " ";
            }
            string output = string.Empty;

            foreach (char c in text)
            {
                output += szyfr(c, 26 - klucz);
            }
            return output;
        }

        public char szyfr(char c, int? klucz)
        { 
            char offset = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + klucz) - offset) % 26) + offset);
        }


    }
}
