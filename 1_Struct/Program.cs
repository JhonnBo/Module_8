namespace _1_Struct
{
    struct Book
    {
        public string Author = "Jim";
        public string Title = "Moon";
        public int Copyright = 2121;
        public Book(string title, string author, int copy)
        {
            Author = author;
            Title = title;
            Copyright = copy;
        }
        //public Book() { } // чтоби иметь возможность использования значений по умолчнию (С#10)

        public override string ToString()
        {
            return Title + ", автор " + Author + ", (c) " + Copyright;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("C# A Beginner's Guide", "Herb Schildt", 2001); // Вызов явно заданного конструктора.
            Book book2 = new Book(); // Вызов конструктора по умолчанию.
            Book book3; // Создание объекта без вызова  конструктора.
            Console.WriteLine(book1.Title + ", автор " + book1.Author + ", (с) " + book1.Copyright);
            Console.WriteLine();

            if (book2.Title == null)
                Console.WriteLine("Поле book2.Title содержит null.\n");

            book2.Title = "С# и платформа .NET. Библиотека программиста";
            book2.Author = "Троелсен. Э.";
            book2.Copyright = 2001;
            Console.Write("Теперь структура book2 содержит:\n");
            Console.WriteLine(book2.Title + ", автор " + book2.Author + ", (c) " + book2.Copyright);
            Console.WriteLine();

            //Console.WriteLine(bоок3.title); // Ошибка: сначала  необходима инициализация.
            book3.Title = "Программирование на платформе Microsoft .NET Framework";
            book3.Author = "Рихтер Дж.";
            book3.Copyright = 2003;
            Console.WriteLine(book3.Title + ", автор " + book3.Author + ", (c) " + book3.Copyright);
            Console.WriteLine();

            Book book4 = new Book();
            Console.WriteLine(book4.ToString());

        }
    }
}