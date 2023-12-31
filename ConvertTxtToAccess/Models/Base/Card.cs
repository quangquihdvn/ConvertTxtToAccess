﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTxtToAccess.Models.Base
{
    public class Card
    {
        public string Value { get; set; }
        public int Length { get; set; }
        public int StartIndex { get; set; }
        public int NextStartIndex
        {
            get
            {
                return Length + StartIndex;
            }
        }

        public void SubValue(string line)
        {
            var cardValue = line.Substring(StartIndex, Length);
            Value = cardValue;
        }

        public void SubValueAndAddSpecialChar(string line, string charStr)
        {
            var cardValue = line.Substring(StartIndex, Length);
            Value = charStr + cardValue + "?";
        }

        public void PadValue(string value)
        {
            Value = value.PadRight(Length, ' ');
        }

        public void SetValue(string value)
        {
            Value = value;
        }
    }
}
