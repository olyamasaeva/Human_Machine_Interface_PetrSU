using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesClass
{
    public class cfProblemStatistics
    {
        int contestId; // может отсутствовать
        String index;
        int solvedCount;

        public cfProblemStatistics(string txt)
        {
            int code;
            this.contestId = QueryParser.findInt(txt, "contestId", out code);
            this.index = QueryParser.findString(txt, "index", out code);
            this.solvedCount = QueryParser.findInt(txt, "solvedCount", out code);
        }
    }
}
