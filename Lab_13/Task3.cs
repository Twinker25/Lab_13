﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    public class Alphabet<T>
    {
        private List<T> letters = new List<T>();
        public void AddLetter(T letter)
        {
            letters.Add(letter);
        }
        public List<T> GetLetters()
        {
            return letters;
        }
    }
}