 class Program
    {
        static void Main(string[] args)
        {
            string str = "�Ϻ�---����---����---�㶫---����---����---ɽ��------����---";
            string[] array = str.Replace("---", "-").Split('-'); //�Ƚ���һ����  
 
            foreach (string  item in array)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine(array.Length);
            Console.WriteLine("\n=======================================================");

            //None ���ص�ֵ���������Ԫ�أ�����һ�����ַ����� RemoveEmptyEntries ����ֵ�������������ַ���������Ԫ��
            string[] Array = str.Split(new string[] { "---" }, StringSplitOptions.None);
            string[] Array01 = str.Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries);  //�鿴���ǵĳ��ȣ�����
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

            //�Զ���ַ����зָ�
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
            
            Console.WriteLine(DateTime.Now.ToString("yyyy��MM��dd�գ�hʱm��s��"));

            Console.ReadKey();
        }
    }