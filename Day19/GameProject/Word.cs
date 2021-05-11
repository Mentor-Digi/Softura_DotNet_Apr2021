using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Word
    {
        public string UserWord { get; set; }
        public int Cows { get; set; }
        public int Bulls { get; set; }
        public bool IsSuccess { get; set; }
        public override string ToString()
        {
            return UserWord + " Cows " + Cows + " Bulls " + Bulls + " Status " + IsSuccess;
        }
    }
}
