using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Информация о контесте на cf
 */
namespace CodeforcesClass
{
    public class cfContest
    {
        int id;
        String name;// локализовано
        enum type { CF, IOI, ICPC };
        type contestType;
        enum phase { BEFORE, CODING, PENDING_SYSTEM_TEST, SYSTEM_TEST, FINISHED };
        phase contestPhase;
        bool frozen;
        int durationSeconds;
        int startTimeSeconds;//  в unix формате, может отсутсвовать
        int relativeTimeSeconds; //  Может отсутствовать
        String preparedBy; // Может отсутсовать
        String websiteUrl; // Может отсутсовать
        String description; // Локализована, может отсутсовать
        String kind; // Локализована, может отсутсвовать
        String icpcRegion; // Локализована, может отсутсвовать
        String country; // Локализована, может отсутсовать
        String city; // Локализована, может отсутствовать
        String season; // может отсутствовать

        public cfContest(string txt)
        {
            int code;
            string res;
            this.id = QueryParser.findInt(txt, "id", out code);
            this.name = QueryParser.findString(txt, "name", out code);
            res = QueryParser.findVal(txt, "type", out code);
            switch (res)
            {
                case "CF":
                    this.contestType = type.CF;
                    break;
                case "IOI":
                    this.contestType = type.IOI;
                    break;
                case "ICPC":
                    this.contestType = type.ICPC;
                    break;
            }
            res = QueryParser.findVal(txt, "phase", out code);
            switch (res)
            {
                case "BEFORE":
                    this.contestPhase = phase.BEFORE;
                    break;
                case "CODING":
                    this.contestPhase = phase.CODING;
                    break;
                case "FINISHED":
                    this.contestPhase = phase.FINISHED;
                    break;
                case "PENDING_SYSTEM_TEST":
                    this.contestPhase = phase.PENDING_SYSTEM_TEST;
                    break;
                case "SYSTEM_TEST":
                    this.contestPhase = phase.SYSTEM_TEST;
                    break;
            }
            res = QueryParser.findVal(txt, "frozen", out code);
            switch (res)
            {
                case "true":
                    this.frozen = true;
                    break;
                case "false":
                    this.frozen = false;
                    break;
            }
            this.durationSeconds = QueryParser.findInt(txt, "durationSeconds", out code);
            this.startTimeSeconds = QueryParser.findInt(txt, "startTimeSeconds", out code);
            this.relativeTimeSeconds = QueryParser.findInt(txt, "relativeTimeSeconds", out code);

            // Unnecessary properties
            this.preparedBy = QueryParser.findString(txt, "preparedBy", out code);
            this.websiteUrl = QueryParser.findString(txt, "websiteURL", out code);
            this.description = QueryParser.findString(txt, "description", out code);
            this.kind = QueryParser.findString(txt, "kind", out code);
            this.icpcRegion = QueryParser.findString(txt, "icpcRegion", out code);
            this.country = QueryParser.findString(txt, "country", out code);
            this.city = QueryParser.findString(txt, "city", out code);
            this.season = QueryParser.findString(txt, "season", out code);

        }
        cfContest(int id, String name, type a, phase b, bool frozen, int durationSeconds, int startTimeSeconds, String preparedBy,
           String websiteUrl, String description, String kind, String icpcRegion, String country, String city, String season)
        {
            this.id = id;
            this.name = name;
            this.frozen = frozen;
            this.contestType = a;
            this.contestPhase = b;
            this.durationSeconds = durationSeconds;
            this.startTimeSeconds = startTimeSeconds;
            this.preparedBy = preparedBy;
            this.websiteUrl = websiteUrl;
            this.description = description;
            this.kind = kind;
            this.icpcRegion = icpcRegion;
            this.country = country;
            this.city = city;
            this.season = season;
        }
    }
}
