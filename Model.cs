using System;
using System.Collections.Generic;
using System.Text;

namespace workshop3._2._2
{
    class Model
    {
        private Data data;

        public void StoreResult(Data data)
        {
            this.data = data;
            data.StringUpper = Convert();
        }

        private string Convert()
        {
            return ToUpperCase(data.String);
        }

        private string ToUpperCase(string text)
        {
            return text.ToUpper();
        }
    }
}
