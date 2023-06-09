using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesClass
{
    public class cfSubmission
    {
        int id;
       public int contestId;//Может отсутствовать
        int creationTimeSeconds;
       public cfProblem problem;
      public  cfParty author;
        String programmingLanguage;
        enum verdict { FAILED, OK, PARTIAL, COMPILATION_ERROR, RUNTIME_ERROR, WRONG_ANSWER, PRESENTATION_ERROR, TIME_LIMIT_EXCEEDED, MEMORY_LIMIT_EXCEEDED, IDLENESS_LIMIT_EXCEEDED, SECURITY_VIOLATED, CRASHED, INPUT_PREPARATION_CRASHED, CHALLENGED, SKIPPED, TESTING, REJECTED };//Может отсутствовать
        verdict Submissionverdict;
        enum testset { SAMPLES, PRETESTS, TESTS, CHALLENGES, TESTS1, TESTS2, TESTS3, TESTS4, TESTS5, TESTS6, TESTS7, TESTS8, TESTS9,TESTS10};
        testset submissiontestset;
        int passedTestCount;
        int timeConsumedMillis;
        int memoryConsumedBytes;
       public cfSubmission() { }
    }
}
