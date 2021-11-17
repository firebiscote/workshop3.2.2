using System;
using System.Collections.Generic;
using System.Text;

namespace workshop3._2._2
{
    class Controller
    {
        public View View;
        public Data Data;
        public Model Model;

        public void Process(string text)
        {
            Data = new Data();
            StoreString(text);
            Model.StoreResult(Data);
            View.Update(Data.StringUpper);
        }

        public void StoreString(string text)
        {
            Data.String = text;
        }
    }
}
