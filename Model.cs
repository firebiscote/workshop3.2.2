using System;
using System.Collections.Generic;
using System.Text;

namespace workshop3._2._2
{
    class Model
    {
        public string Convert(string text)
        {
            return ToUpperCase(text);
        }

        private string ToUpperCase(string text)
        {
            return text.ToUpper();
        }
    }
}
