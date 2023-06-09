using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesClass
{
    public class cfProblemResult
    {
        double points;
        int penalty;
        int rejectedAttemptCount;
        enum type { PRELIMINARY, FINAL };
        type ProbemResulttype;
        int bestSubmissionTimeSeconds;

        public cfProblemResult(string txt)
        {
            int code;
            this.points = QueryParser.findDouble(txt, "points", out code);
            this.penalty = QueryParser.findInt(txt, "penalty", out code);
            this.rejectedAttemptCount = QueryParser.findInt(txt, "rejectedAttemptCount", out code);
            string res;
            res = QueryParser.findVal(txt, "problemResultType", out code);
            switch (res)
            {
                case "PRELIMINARY":
                    this.ProbemResulttype = type.PRELIMINARY;
                    break;
                case "FINAL":
                    this.ProbemResulttype = type.FINAL;
                    break;
            }
            this.bestSubmissionTimeSeconds = QueryParser.findInt(txt, "bestSubmissionTimeSeconds", out code);
        }
    }
}
