using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Ladder
{
    //find all shortest transformation sequence(s) from beginWord to endWord
    //beginWord = "hit"
    //endWordWord = "cog"
    //wordList<string> = ["hot","dot","dog","lot","log","cog"]
    //  Return
    //[ ["hit","hot","dot","dog","cog"], ["hit","hot","lot","log","cog"] ]
    class Program
    {
        static void Main(string[] args)
        {
            string beginWord = "hit";
            string endWord = "cog";
            List<string> wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
            Method wordladder = new Method();

            Console.WriteLine("the Result is {0}", wordladder.ladderMethod(beginWord, endWord, wordList));
            Console.ReadKey();
        }
    }
    class Method
    {
        public string ladderMethod(String start, String end, List<string> dict)
        {
            if (start==null||end==null|| dict==null||dict.Count==0)
            {
                Console.WriteLine("the raw data is not enough!!");
            }

            List<string> ResultList = new List<string> { start };
            string result = "";
            for (int k =0; k < dict.Count; k++)
            {              
                string Word = start;
                for (var i = 0; i < Word.Length; i++)
                {
                    for (var ch = 'a'; ch < 'z'; ch++)
                    {
                        if (ch == Word[i])
                        {
                            continue;
                        }
                        string temp = replaceLetter(Word, i,ch);

                        if (dict.Contains(temp) && (!ResultList.Contains(temp)))
                        {
                            ResultList.Insert(k+1, temp);
                            start = temp;                       
                        }                       
                    }
               }                                         
            }
            ResultList.RemoveRange(ResultList.IndexOf(end)+1, dict.Count - ResultList.IndexOf(end));
            result = string.Join("->", ResultList.ToArray());
            return result;
        }
        private static String replaceLetter(String s, int index, char c)
        {
            char[] chars = s.ToCharArray();
            chars[index] = c;
            return new String(chars);
        }
    }
}

