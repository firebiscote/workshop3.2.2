using System;
using System.Collections.Generic;
using System.Text;

namespace workshop3._2._2
{
    class View
    {
        private string text;
        public string Text
        {
            get => text;
            set
            {
                if (value.Length < 1 || value.Length > 8)
                {
                    Console.WriteLine("La chaine de caractères entrée n'est pas valide !");
                    Text = Console.ReadLine();
                }
                else
                    text = value;
            }
        }

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
    }
}
