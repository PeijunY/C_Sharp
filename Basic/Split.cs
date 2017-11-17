 class Program
    {
        static void Main(string[] args)
        {
            string str = "上海---北京---深圳---广东---福建---厦门---山西------江西---";
            string[] array = str.Replace("---", "-").Split('-'); //先进行一步简化  
 
            foreach (string  item in array)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine(array.Length);
            Console.WriteLine("\n=======================================================");

            //None 返回的值包括数组的元素，包含一个空字符串； RemoveEmptyEntries 返回值不包括包含空字符串的数组元素
            string[] Array = str.Split(new string[] { "---" }, StringSplitOptions.None);
            string[] Array01 = str.Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries);  //查看它们的长度！！！
            foreach (string item in Array)
            {ss
                Console.Write("{0} ", item);
            }
            Console.WriteLine(array.Length);
            Console.WriteLine("\n=======================================================");

            foreach (string item in Array01)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine(Array01.Length);
            Console.WriteLine("\n=======================================================");

            //对多个字符进行分割
            string s = "abceasgdabs:gegeabeeeab";
            string[] Mutiarray = s.Split(new char[] { 'c','e',':'});
            
            foreach (string item in Mutiarray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\n=======================================================");
            string[] Multi = s.Split('c', ':', 'g', 'e');
            foreach (string item in Multi)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\n=======================================================");
            
            Console.WriteLine(DateTime.Now.ToString("yyyy年MM月dd日，h时m分s秒"));

            Console.ReadKey();
        }
    }