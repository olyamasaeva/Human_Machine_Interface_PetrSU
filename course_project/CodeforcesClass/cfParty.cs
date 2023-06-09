using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesClass
{
    public class cfParty
    {
        int contestId; // может отсутстовать
       public List<cfMember> members;
        enum participantType { CONTESTANT, PRACTICE, VIRTUAL, MANAGER, OUT_OF_COMPETITION };
        participantType PartyType;
      public  int teamId; // Может отсутствовать
  public  String teamName; // Локализовано, может отсутсвовать
        bool ghost;
        int room; //может отсутсвовать
        int startTimeSeconds;
    }
}
