namespace _2_Struct_vs_Class
{
    class B
    {
        int r = 10;
        public B(int n)
        {
            r = n;

        }
        public int propR
        {
            get { return r; }
            set { r = value; }
        }
    }
    struct C
    {
        int r = 10; //значение по умолчанию *не* допустимо
        public C(int n)
        {
            r = n;

        }
        public int propR
        {
            get { return r; }
            set { r = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj1 = new B(5);
            Console.WriteLine("Печать объекта класса obj1");
            Console.WriteLine(obj1.propR);
            B obj2 = obj1;
            obj2.propR = 100;
            Console.WriteLine("\nПечать объекта класса obj1 после присваивания");
            Console.WriteLine(obj1.propR);
            Console.WriteLine("\n");

            C obj3 = new C(7);
            Console.WriteLine("Печать объекта структуры obj3");
            Console.WriteLine(obj3.propR);
            C obj4 = obj3;
            obj4.propR = 100;
            Console.WriteLine("\nПечать объекта структуры obj3 после присваивания");
            Console.WriteLine(obj3.propR);
        }
    }
}