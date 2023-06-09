﻿using System.Collections.Generic;
using System.Threading.Tasks;
using cfapi.Objects;

namespace cfapi.Methods
{
    public class ContestStandingsRequest : RequestBase<Standing>
    {
        /// <summary>
        /// Requests standings of the specified contest.
        /// </summary>
        /// <param name="contestId"></param>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <param name="handles"></param>
        /// <param name="room"></param>
        /// <param name="showUnofficial"></param>
        /// <returns></returns>
        public async Task<Standing> GetContestStandingsAsync(int contestId, int from = 1, int count = 0, List<string> handles = null, int room = 0, bool showUnofficial = false)
        {
            var req = $"http://codeforces.com/api/contest.standings?contestId={contestId}";

            if (count != 0) 
                req += $"&from={from}&count={count}";
        
            req += $"&showUnofficial={showUnofficial}";
            var ret = await GetAsync(req);
            return ret?.Result[0];
        }

        /// <summary>
        /// Requests standings of the specified contest.
        /// </summary>
        /// <param name="contestId"></param>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <param name="handles"></param>
        /// <param name="room"></param>
        /// <param name="showUnofficial"></param>
        /// <returns></returns>
        public Standing GetContestStandings(int contestId, int from = 1, int count = 0, List<string> handles = null, int room = 0, bool showUnofficial = false)
        {
            var req = $"http://codeforces.com/api/contest.standings?contestId={contestId}";

            if (count != 0)
                req += $"&from={from}&count={count}";
            if(handles.Count > 0)
            {
                req += "&handles=";
                int cnt = 0;
                foreach(var name in handles)
                {
                    req += name;
                    if (cnt != handles.Count - 1)
                        req += ";";
                    cnt++;
                }
            }
            if (showUnofficial)
                req += "&showUnofficial=true";

            var ret = Get(req);
            return ret?.Result[0];
        }
    }
}