using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesClass
{
    public class cfRanklistRow
    {
        cfParty party;
        int rank;
        double points;
        int penalty;
        int successfulHackCount;
        int unsuccessfulHackCount;
        List<cfProblemResult> problemResults;
        int lastSubmissionTimeSeconds;
    }
}
