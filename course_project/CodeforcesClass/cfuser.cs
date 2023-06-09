using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesClass
{
    public class user
    {
        String handle;
        String email; //не всегда есть
        String vkId; //не всегда есть
        String openId; //не всегда есть
        String firstName;//локализованы
        String lastName;//локализованы
        String country;//локализованы
        String city;//локализованы
        String organization;//локализованы
        int contribution;
        String rank;//локализованы
        int rating;
        String maxRank;//локализованы
        int maxRating;
        int lastOnlineTimeSeconds;
        int registrationTimeSeconds;
        int friendOfCount;
        String avatar;
        String titlePhoto;

        public user(string txt)
        {
            
            int code;
            this.handle = QueryParser.findString(txt, "handle", out code);
            this.email = QueryParser.findString(txt, "email", out code);
            this.vkId = QueryParser.findString(txt, "vkId", out code);
            this.openId = QueryParser.findString(txt, "openId", out code);
            this.firstName = QueryParser.findString(txt, "firstName", out code);
            this.lastName = QueryParser.findString(txt, "lastName", out code);
            this.country = QueryParser.findString(txt, "country", out code);
            this.city = QueryParser.findString(txt, "city", out code);
            this.organization = QueryParser.findString(txt, "organization", out code);
            this.contribution = QueryParser.findInt(txt, "contribution", out code);
            this.rank = QueryParser.findString(txt, "rank", out code);
            this.rating = QueryParser.findInt(txt, "rating", out code);
            this.maxRank = QueryParser.findString(txt, "maxRank", out code);
            this.maxRating = QueryParser.findInt(txt, "maxRating", out code);
            this.lastOnlineTimeSeconds = QueryParser.findInt(txt, "lastOnlineTimeSeconds", out code);
            this.registrationTimeSeconds = QueryParser.findInt(txt, "registrationTimeSeconds", out code);
            this.friendOfCount = QueryParser.findInt(txt, "friendOfCount", out code);
            this.avatar = QueryParser.findString(txt, "avatar", out code);
            this.titlePhoto = QueryParser.findString(txt, "titlePhoto", out code);
        }
    }
}
