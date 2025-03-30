using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class ZigZag_Conversion_6
    {
        public string Convert(string s, int numRows)
        {
            if (s.Length == 1 || numRows == 1) return s;

            StringBuilder returnString = new StringBuilder();
            List<StringBuilder> builderList = new List<StringBuilder>();

            for (int i = 0; i < numRows; i++)
            {
                builderList.Add(new StringBuilder());
            }

            int rowIter = 0;
            bool countUp = true;

            foreach (var letter in s)
            {
                builderList[rowIter].Append(letter);

                if (rowIter == numRows - 1) countUp = false;
                else if (rowIter == 0) countUp = true;

                rowIter += countUp ? 1 : -1;
            }

            foreach (var row in builderList)
            {
                returnString.Append(row);
            }

            return returnString.ToString();
        }
    }
}
