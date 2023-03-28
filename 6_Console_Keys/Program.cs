namespace _6_Console_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            char keyChar;
            Console.TreatControlCAsInput = true;

            do
            {
                // Console.ReadKey() получает следующий нажатый пользователем символ или функциональную клавишу. 
                // Нажатая клавиша отображается в окне консоли. 
                ConsoleKeyInfo info = Console.ReadKey(true);
                // ConsoleKeyInfo описывает нажатую клавишу консоли, включая символ, представленный этой клавишей, 
                // и состояние управляющих клавиш CTRL, SHIFT и ALT.
                key = info.Key; // Возвращает клавишу консоли, представленную текущим объектом ConsoleKeyInfo.
                Console.WriteLine(key);
                // Console.WriteLine((int)key); // можно вывести код клавиши, т.е. перечисления
            } while (key != ConsoleKey.Escape);

            do
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                keyChar = info.KeyChar;
                Console.WriteLine(keyChar); // Возвращает символ Юникода, представленный текущим объектом ConsoleKeyInfo.
            } while (keyChar != 27);
        }
    }
}

// ConsoleKey Перечисление
// https://learn.microsoft.com/ru-ru/dotnet/api/system.consolekey?view=net-7.0