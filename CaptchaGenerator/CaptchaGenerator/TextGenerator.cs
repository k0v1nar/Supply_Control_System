using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaGenerator
{
    public class TextGenerator
    {
        static private Random _rnd = new Random();
        static public string _symbols = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";

        static public string GetText()
        {
            string text = "";
            for (int i = 0; i < _rnd.Next(5, 10); i++)
            {
                text += _symbols[_rnd.Next(_symbols.Length)];
            }
            return text;
        }
    }
}
