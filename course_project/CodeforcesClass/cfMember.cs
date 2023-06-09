using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesClass
{
    public class cfMember
    {
       public String handle;

        public cfMember(string txt)
        {
            int code;
            this.handle = QueryParser.findString(txt, "handle", out code);
        }
        public List<cfSubmission> status(String Handler,int from, int count)
        {
            List<cfSubmission> a = new List<cfSubmission>();
            return a;
        } 
    }
}
