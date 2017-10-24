using System;
public class BaseClass
{
    private string name;
    public string Name
    {
        get
        {           return name;        }
        set
        {           name = value;       }
    }
}
#region This is derived class zone!
public class DerivedClass : BaseClass
{
    private string name;

    /// <summary>
    /// �������е����� Name ���ػ����е����� Name������������£�������ĸ���������ʹ�� new ���η�
    /// </summary>
    public new string Name   // Notice the use of the new modifier
    {
        get
        {            return name;        }
        set
        {            name = value;       }
    }
}
#endregion
public class MainClass
{
    public static void Main()
    {
        DerivedClass d1 = new DerivedClass();
        d1.Name = "John"; // Derived class property
        Console.WriteLine("Name in the derived class is: {0}", d1.Name);
        ((BaseClass)d1).Name = "Mary"; // Base class property. be careful of this kind of write method.
        Console.WriteLine("Name in the base class is: {0}",((BaseClass)d1).Name);
        Console.ReadKey();
    }
}
