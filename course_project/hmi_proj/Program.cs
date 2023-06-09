using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace hmi_proj
{
    
  // need to commint
    
  public static class Program
    {
        public static HashSet<String> myTasks ;
        public static Trains trainsform;
        public static String getLocalLine(String text)
        {
            Encoding utf8 = Encoding.GetEncoding("UTF-8");
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");

            byte[] utf8Bytes = win1251.GetBytes(text);
            byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);
             return win1251.GetString(win1251Bytes);
        }
        public static bool isTask(string name)
        {
            foreach(var it in myTasks)
            {
                String[] words = it.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length < 2)
                    continue;
                if (words[1] == name)
                    return true;
            }
            return false;
        }
        public static string findTask(string name)
        {
            if (!isTask(name))
                return "";
            foreach (var it in myTasks)
            {
                String[] words = it.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length < 2)
                    continue;
                if (words[1] == name)
                    return it;
            }
            return "";
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* List<string> a = new List <string> ();
            a.Add("Tvorobusheck");
            a.Add("olya.masaeva");
            List<string> res = QueryMaker.makeQuery("user.info?handles=", a);
            CodeforcesClass.user tvorobusheck = new user(res[0]);*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             trainsform = new Trains();
            Application.Run(trainsform);            
        }

    }
}
