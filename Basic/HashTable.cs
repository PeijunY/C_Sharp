1. public virtual void Add( object key, object value ); 
向 Hashtable 添加一个带有指定的键和值的元素。
2. public virtual void Clear(); 
从 Hashtable 中移除所有的元素。
3. public virtual bool ContainsKey( object key ); 
判断 Hashtable 是否包含指定的键。
4. public virtual bool ContainsValue( object value ); 
判断 Hashtable 是否包含指定的值。
5. public virtual void Remove( object key ); 
从 Hashtable 中移除带有指定的键的元素。
===================================================================================================
以下这个代码包含上面所有！！熟悉这个使用方法！！！
Hashtable 类代表了一系列基于键的哈希代码组织起来的键/值对。它使用键来访问集合中的元素。
===================================================================================================
using System;
using System.Collections; //file使用Hashtable时，必须引入这个命名空间
class Program
{
    public static void Main()
    {
        Hashtable ht = new Hashtable(); //创建一个Hashtable实例
        ht.Add("北京", "帝都"); //添加key and value键值对
        ht.Add("上海", "魔都");
        ht.Add("广州", "省会");
        ht.Add("深圳", "特区");

        string capital = (string)ht["北京"];
        Console.WriteLine(ht.Contains("上海")); //“判断” 哈希表是否包含特定键,其返回值为true或false

        foreach (var s in ht.Keys)
        {
            Console.WriteLine(s + ": " + ht[s]);  //*****ht[s]表示键key为s时，ht的value*****
        }
        //ICollection key = ht.Keys;      //等同以上
        //foreach (string s in key)
        //{
        //    Console.WriteLine(s + ":" + ht[s]);           
        //}
        Console.WriteLine("============================");

        ht.Remove("深圳");                        //移除一个keyvalue键值对
        //ht.Clear(); //移除所有元素  

        //foreach (string s in key)
        //{
        //    Console.WriteLine(s + ":" + ht[s]);
        //}

        Console.ReadKey();
    }
}
=========================================================================================
 遍历哈希表
 遍历哈希表需要用到DictionaryEntry Object，代码如下：
for(DictionaryEntry de in ht) //ht为一个Hashtable实例
{
   Console.WriteLine(de.Key);  //de.Key对应于keyvalue键值对key
   Console.WriteLine(de.Value);  //de.Key对应于keyvalue键值对value
}
 
遍历键
foreach (int key in hashtable.Keys)
{
    Console.WriteLine(key);
}
 
遍历值
foreach (string value in hashtable.Values)
{
    Console.WriteLine(value);
}
