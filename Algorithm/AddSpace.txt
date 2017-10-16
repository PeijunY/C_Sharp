using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_add_space
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aasjgljadgsfsnfrnmask";
            Addmethod method = new Addmethod();
            
            Console.WriteLine(method.AddSpace(s1, 1));
            Console.ReadKey();
        }
    }
    class Addmethod
    { 
        /// <summary>
        /// Add some special char on every some space!
        /// </summary>
        /// <param name="text"></param>
        /// <param name="spaceIndex"></param>
        /// <returns></returns>
        public string AddSpace(string text,int spaceIndex)
        {
            StringBuilder sb = new StringBuilder(text);
            for (int i=spaceIndex; i<=sb.Length; i+=spaceIndex+1)
            {
                sb.Insert(i, " ");
            }
            return sb.ToString();
        }        
    }
}
