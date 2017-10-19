1. public virtual void Add( object key, object value ); 
�� Hashtable ���һ������ָ���ļ���ֵ��Ԫ�ء�
2. public virtual void Clear(); 
�� Hashtable ���Ƴ����е�Ԫ�ء�
3. public virtual bool ContainsKey( object key ); 
�ж� Hashtable �Ƿ����ָ���ļ���
4. public virtual bool ContainsValue( object value ); 
�ж� Hashtable �Ƿ����ָ����ֵ��
5. public virtual void Remove( object key ); 
�� Hashtable ���Ƴ�����ָ���ļ���Ԫ�ء�
===================================================================================================
���������������������У�����Ϥ���ʹ�÷���������
===================================================================================================
using System;
using System.Collections; //fileʹ��Hashtableʱ������������������ռ�
class Program
{
    public static void Main()
    {
        Hashtable ht = new Hashtable(); //����һ��Hashtableʵ��
        ht.Add("����", "�۶�"); //���key and value��ֵ��
        ht.Add("�Ϻ�", "ħ��");
        ht.Add("����", "ʡ��");
        ht.Add("����", "����");

        string capital = (string)ht["����"];
        Console.WriteLine(ht.Contains("�Ϻ�")); //���жϡ� ��ϣ���Ƿ�����ض���,�䷵��ֵΪtrue��false

        foreach (var s in ht.Keys)
        {
            Console.WriteLine(s + ": " + ht[s]);  //*****ht[s]��ʾ��keyΪsʱ��ht��value*****
        }
        //ICollection key = ht.Keys;      //��ͬ����
        //foreach (string s in key)
        //{
        //    Console.WriteLine(s + ":" + ht[s]);           
        //}
        Console.WriteLine("============================");

        ht.Remove("����");                        //�Ƴ�һ��keyvalue��ֵ��
        //ht.Clear(); //�Ƴ�����Ԫ��  

        //foreach (string s in key)
        //{
        //    Console.WriteLine(s + ":" + ht[s]);
        //}

        Console.ReadKey();
    }
}