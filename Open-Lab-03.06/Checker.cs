using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
            char s = ' ';
            if (str.Contains(s))
            {
                return true;
            }    
            else
            {
                return false;
            }
        }
    }
}
