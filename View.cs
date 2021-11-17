using System;
using System.Collections.Generic;
using System.Text;

namespace workshop3._2._2
{
    class View
    {
        public Controller Controller;
        private string stringToShow;
        public string StringToShow
        {
            get => stringToShow;
            set
            {
                stringToShow = value;
                Console.WriteLine(stringToShow);
            }
        }

        public void GetUserInputs()
        {
            checkString(Console.ReadLine());
        }

        private void checkString(string text)
        {
            if (isStringLenghtValid(text))
                Controller.Process(text);
            else
                GetUserInputs();
        }
        
        private bool isStringLenghtValid(string text)
        {
            return text.Length < 9 && text.Length > 0;
        }

        public void Update(string text)
        {
            Console.WriteLine(text);
        }
    }
}
