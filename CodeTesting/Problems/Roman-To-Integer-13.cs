using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Roman_To_Integer_13
    {
        public int RomanToInt(string s)
        {
            var total = 0;
            for(int i = 0; i < s.Length; i++)
            {
                switch(s[i])
                {
                    case 'I':
                        if(i != s.Length - 1)
                        {
                            if (s[i + 1] == 'V')
                            {
                                total += 4;
                                i++;
                                break;
                            }

                            if (s[i + 1] == 'X')
                            {
                                total += 9;
                                i++;
                                break;

                            }
                            else total++;
                        }
                        else
                        {
                            total++;
                        }
                        break;

                    case 'V':
                        total += 5;
                        break;

                    case 'X':
                        if(i != s.Length - 1)
                        {
                            if (s[i + 1] == 'L')
                            {
                                total += 40;
                                i++;
                                break;

                            }

                            if (s[i + 1] == 'C')
                            {
                                total += 90;
                                i++;
                                break;

                            }

                            else total += 10;
                        }
                        else
                        {
                            total += 10;
                        }
                        break;

                    case 'L':

                        total+= 50;
                        break;

                    case 'C':

                        if(i != s.Length - 1)
                        {
                            if (s[i + 1] == 'D')
                            {
                                total += 400;
                                i++;
                                break;

                            }

                            if (s[i + 1] == 'M')
                            {
                                total += 900;
                                i++;
                                break;

                            }

                            else total += 100;
                        }
                        else
                        {
                            total += 100;
                        }

                        break;

                    case 'D':
                        total += 500;
                        break;

                    case 'M':
                        total += 1000;
                        break;
                }
            }
            return total;
        }
    }
}
