First:
 class Program
    {
        static void Main(string[] args)
        {
            
            StreamReader sr = new StreamReader(@"D:\1.txt");
            while (!sr.EndOfStream)
            {
                string currentLine = sr.ReadLine();
                string[] curLineItems = currentLine.Split(new string[] { "," }, StringSplitOptions.None);
                
                foreach (var item in curLineItems)
                {
                    if (item == "")
                        Console.Write("0 ");
                    else
                        Console.Write(item + " ");
                }
                Console.Write("\r\n");
            }
            sr.Close();
        }
    }
Second:
  class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\v-peiy\Desktop\PY\PY.txt");
            //StreamWriter sw = new StreamWriter(@"d:\result2.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\v-peiy\Desktop\PY\result.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] cells = line.Split('\t');
                if (cells.Length < 6)
                {
                    continue;
                }
                if (!cells[1].Contains("SignPostTest"))
                {
                    continue;
                }
                string entity1Id = cells[4];
                string log = cells[5];
                string[] wordsInLog = log.Split(' ');
                if (wordsInLog.Length < 5)
                {
                    continue;
                }
                string entity2Id = wordsInLog[12];
                sw.WriteLine(entity1Id + "  " + entity2Id);
                //sw.WriteLine(entity1Id + ",#" + entity2Id);
            }
            sw.Close();
        }

    }
Third:
           StreamReader sr = new StreamReader(@"C:\Users\v-peiy\Desktop\PY\PY.txt");
            //Dictionary<long, long> dict = new Dictionary<long, long>();
            //List<Tuple<long, long>> RowList = new List<Tuple<long, long>>();
            while (!sr.EndOfStream)
            {
                string curRow = sr.ReadLine();
                long entityId = long.Parse(curRow.Substring(0, curRow.IndexOf("\t")));
                long id = long.Parse(curRow.Substring(curRow.IndexOf("\t") + 1));
                if (!dict.ContainsKey(entityId))
                    dict.Add(entityId, id);
                //MessageBox.Show(string.Format("Entrity Id: {0}, Id = {1}", entityId, id));
            }
            sr.Close();
            int rowNo = 1;
            foreach (var item in dict)
            {

                MessageBox.Show(string.Format("Entity Id: {0}, Id = {1}", item.Key, item.Value));
            }
