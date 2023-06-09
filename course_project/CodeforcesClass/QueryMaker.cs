using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesClass
{
    public static class QueryMaker
    {
        /**
         * Make query to cfapi
         * command means method
         * param means names, id and etc.
         * 
         * DON"T USE SPACES!!!
         * 
         * Example, "user.info?handles=", List: "Tvorobusheck","olya.masaeva"
         */
        public static List <string> makeQuery(string command, List <string> param)
        {
            List<string> ans = new List<string>();
            string args = "";
            foreach (string cur in param)
                args += cur + ";";
            string res = run_script("mes.py", command + args);
            int code;
            if (QueryParser.findString(res, "status", out code) == "FAILED" || code != 0)
                return ans;
            else
            {
                int cnt = 0;
                int beg, end;
                for (beg = 1; beg < res.Length; beg++)
                    if (res[beg] == '{')
                        break;
                for (end = res.Length - 2; end >= 0; end--)
                    if (res[end] == '}')
                        break;
                if (beg == res.Length || end == -1)
                    return ans;
                int last;
                int prevlvl = 0, curlvl = 0;
                do
                {
                    string cur = "";
                    for (last = beg; last < res.Length; last++)
                    {
                        if (res[last] == '{')
                        {
                            curlvl++;
                            cnt++;
                            continue;
                        }
                        if (res[last] == '}')
                            cnt--;
                        if (cnt == 0)
                        {
                            last++;
                            break;
                        }
                        cur += res[last];
                    }
                    beg = last;
                    if (curlvl > prevlvl)
                    {
                        prevlvl = curlvl;
                        ans.Add(cur);
                    }
                } while (last != end);
            }
            return ans;
        }
        /**
         * Runs python script from python_script folder,
         * returns result
         * scriptName is fullname, from python_script,
         * Example, mes.py
         */
        static string run_script(string scriptName, string args)
        {

            string working_directory;
#if (VLAD)
            working_directory = "D:/Data/VSRepos";
#elif (OLYA)
            working_directory = "C:/Users/user/Desktop/hmi";
#else
            working_directory = "D:/Data/VSRepos";
#endif
            return run_cmd(working_directory + "/hmi_proj/hmi_proj/python_script/" + scriptName, args);
        }

        private static string run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            string PythonPath;
#if (VLAD)
            PythonPath = "C:/Users/В/AppData/Local/Programs/Python/Python37-32/python.exe";
#elif (OLYA)
            PythonPath = "C:/Users/user/AppData/Local/Programs/Python/Python36-32/python.exe";
#else
            PythonPath = "C:/Users/В/AppData/Local/Programs/Python/Python37-32/python.exe";
#endif
            start.FileName = PythonPath;
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
