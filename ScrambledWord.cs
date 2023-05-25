﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace The_ScrambLearner
{
    
    internal class ScrambledWord
    {
        public string Word { get; set; }
        public string WordScramble { get; set; }
        public string Difficulty { get; set; }

        public int AttemptPoints { get; set; }
        
        public int NumberOfTries { get; set; }
    }
}
