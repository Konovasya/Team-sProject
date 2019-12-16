using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp
{
    public class Question
    {
        public int Number { get; set; }

        public string Text { get; set; }

        public string FirstAnswer { get; set; }

        public string SecondAnswer { get; set; }
        
        public string ThirdAnswer { get; set; }

        public int CorrectAnswer { get; set; }

    }
}
