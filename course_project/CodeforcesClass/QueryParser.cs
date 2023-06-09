using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesClass
{
    static class QueryParser
    {
        /**
         * Return value of property, which was found in txt
         * code = -1 means parsing error
         * code = 0 success
         * code = 1 property length > txt length
         */

        public static string findString(string txt, string property, out int code)
        {
            for (int i = 0; i <= txt.Length - property.Length; i++)
            {
                if (property == txt.Substring(i, property.Length))
                {
                    int beg = txt.Length + 1;
                    int j;
                    bool flag = false;
                    for (j = i + property.Length + 2; j < txt.Length; j++)
                    {
                        if (flag)
                            beg = Math.Min(beg, j);
                        if (flag && txt[j] == '\'')
                            break;
                        if (txt[j] == '\'')
                            flag = true;
                    }
                    if (flag && j >= beg)
                    { 
                        code = 0;
                        return txt.Substring(beg, j - beg);
                    }
                    code = -1;
                    return "";
                }
            }
            code = 1;
            return "";
        }

        /**
         * Return value of property, which was found in txt
         * code = -1 means parsing error
         * code = 0 success
         * code = 1 property length > txt length
         */
        public static int findInt(string txt, string property, out int code)
        {
            for(int i = 0; i <= txt.Length - property.Length; i++)
            {
                if (property == txt.Substring(i, property.Length))
                {
                    int beg = txt.Length + 1;
                    int j;
                    bool flag = false;
                    for(j = i + property.Length; j < txt.Length; j++)
                    {
                        if (Char.IsDigit(txt[j]))
                            flag = true;
                        if(flag)
                            beg = Math.Min(beg, j);
                        if (flag && !Char.IsDigit(txt[j]))
                            break;
                    }
                    if (flag)
                    {
                        code = 0;
                        return int.Parse(txt.Substring(beg, j - beg));
                    }
                    code = -1;
                    return 0;
                }
            }
            code = 1;
            return 0;
        }

        /**
         * Return value of property, which was found in txt
         * code = -1 means parsing error
         * code = 0 success
         * code = 1 property length > txt length
         */
        public static double findDouble(string txt, string property, out int code)
        {
            for (int i = 0; i <= txt.Length - property.Length; i++)
            {
                if (property == txt.Substring(i, property.Length))
                {
                    int beg = txt.Length + 1;
                    int j;
                    bool flag = false;
                    for (j = i + property.Length; j < txt.Length; j++)
                    {
                        if (Char.IsDigit(txt[j]))
                            flag = true;
                        if (flag)
                            beg = Math.Min(beg, j);
                        if (flag && !Char.IsDigit(txt[j]))
                            break;
                    }
                    if (flag)
                    {
                        code = 0;
                        return double.Parse(txt.Substring(beg, j - beg));
                    }
                    code = -1;
                    return 0;
                }
            }
            code = 1;
            return 0;
        }

        /**
         * Return value of property, which was found in txt
         * code = -1 means parsing error
         * code = 0 success
         * code = 1 property length > txt length
         */
        public static string findVal(string txt, string property, out int code)
        {
            for (int i = 0; i <= txt.Length - property.Length; i++)
            {
                if (property == txt.Substring(i, property.Length))
                {
                    int beg = i + property.Length + 3;
                    int j;
                    for (j = i + property.Length + 3; j < txt.Length; j++)
                    {
                        if (txt[j] == '\n' || txt[j] == ',')
                            break;
                    }
                    code = 0;
                    return txt.Substring(beg, j - beg);
                }
            }
            code = 1;
            return "";
        }

    }

}
