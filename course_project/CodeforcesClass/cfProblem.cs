using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesClass
{
    public class cfProblem
    {
        int contestId; // Может отсутствовать
        String problemsetName; // Может отсутствовать
        String index;
        String name; // Локализована
        enum type { PROGRAMMING, QUESTION };
        type Probemtype;
        double points; // Может отсутствовать
        int rating; // Может отсутствовать
        List<String> tags;
    }
}
