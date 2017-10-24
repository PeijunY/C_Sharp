namespace generic
{
    /// <summary>
    /// 泛型的扩展方法！！
    /// </summary>
    static class ExtendHolder  //must be "static" 
    {
        public static void Print<T>(this Holder<T> h)   //must be "this"
        {
            T[] vals = h.GetValues();
            Console.WriteLine("{0}, \t{1}, \t{2}", vals[0], vals[1], vals[2]);
        }
    }
    class Holder<T>
    {
        T[] vals = new T[3];
        public Holder(T v0, T v1, T v2)
        {
            vals[0] = v0; vals[1] = v1; vals[2] = v2;
        }
        public T[] GetValues()
        {
            return vals;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var intHolder = new Holder<int>(3, 5, 7);
            var stringHolder = new Holder<string>("a1","a2","a3");
            intHolder.Print();
            stringHolder.Print();
        }
    }
}