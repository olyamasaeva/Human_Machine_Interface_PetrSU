using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesClass
{
    public class cfRatingChange
    {
        int contestId;
        String contestName;//локализовано
        String handle;
        int rank; 
        int ratingUpdateTimeSeconds;// в unix формате
        int oldRating;
        int newRating;

        public cfRatingChange(string txt)
        {
            int code;
            this.contestId = QueryParser.findInt(txt, "contestId", out code);
            this.contestName = QueryParser.findString(txt, "contestName", out code);
            this.handle = QueryParser.findString(txt, "handle", out code);
            this.rank = QueryParser.findInt(txt, "rank", out code);
            this.ratingUpdateTimeSeconds = QueryParser.findInt(txt, "ratingUpdateTimeSeconds", out code);
            this.oldRating = QueryParser.findInt(txt, "oldRating", out code);
            this.newRating = QueryParser.findInt(txt, "newRating", out code);
        }
    }
}
