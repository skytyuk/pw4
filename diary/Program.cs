namespace diary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022, 11, 4);
            ConsoleKeyInfo key;
            int cursor = 1;
            int day = date.DayOfYear;
            List<string> name = new List<string>();
            List<string> text = new List<string>();
            List<string> text2 = new List<string>();
            text.Add("Описание: с 18 00 по 22 00 ");
            text.Add("Описание: наесться и пойти поспать до 14 00 ");
            text.Add("Описание: играть в siege");
            text.Add("Описание: с 6 00 до 8 00 ");
            text.Add("Описание: обязательно прихватить еды");
            name.Add("Сделать практическую");
            name.Add("Поспать");
            name.Add("Пойти поиграть");
            name.Add("Заняться спортом");
            name.Add("Почитать мангу");
            text2.Add("--------------------");
            int menu = 1;
            Menu();
            Menu2();

            do
            {
                switch (menu)
                {
                    case 1:
                        Menu();
                        Menu2();
                        break;
                    case 2:
                        notes();
                        break;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    menu = 2;
                    if ((key.Key == ConsoleKey.Enter) && (cursor == 4))
                    {
                        menu = 1;
                    }
                }
            } while (true);

            void Menu2()
            {
                switch (day)
                {
                    case 309:
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine("  1. Сделать практическую");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine("  2. Поспать");
                        break;
                    case 310:
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine("  1. Пойти поиграть");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine("  2. Заняться спортом");
                        break;
                    case 308:
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine("  1. Почитать мангу");
                        break;
                }
            }

            void Menu()
            {
                key = Console.ReadKey();
                date_switch();
                notes_switch();
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выбрана дата " + date.ToShortDateString());
                Console.SetCursorPosition(0, cursor);
                Console.WriteLine("->");
            }

            void date_switch()
            {
                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        date = date.AddDays(1);
                        day += 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        date = date.AddDays(-1);
                        day -= 1;
                        break;
                }
            }

            void notes_switch()
            {
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        cursor++;
                        switch (day)
                        {
                            case 309:
                                if (cursor > 2)
                                {
                                    cursor = 2;
                                }
                                break;
                            case 310:
                                if (cursor > 2)
                                {
                                    cursor = 2;
                                }
                                break;
                            case 308:
                                if (cursor > 1)
                                {
                                    cursor = 1;
                                }
                                break;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        cursor--;
                        if (cursor < 1)
                        {
                            cursor = 1;
                        }
                        break;
                }
            }

            void notes()
            {
                switch (day)
                {
                    case 309:
                        if ((key.Key == ConsoleKey.Enter) && (cursor == 1))
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine(name[0]);
                            Console.SetCursorPosition(0, 1);
                            Console.WriteLine(text2[0]);
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine(text[0]);
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine(date);
                            Console.SetCursorPosition(0, cursor = 4);
                        }
                        else if ((key.Key == ConsoleKey.Enter) && (cursor == 2))
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine(name[1]);
                            Console.SetCursorPosition(0, 1);
                            Console.WriteLine(text2[0]);
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine(text[1]);
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine(date);
                            Console.SetCursorPosition(0, cursor = 4);
                        }
                        else
                        {
                            Menu();
                            Menu2();
                        }
                        break;
                    case 310:
                        if ((key.Key == ConsoleKey.Enter) && (cursor == 1))
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine(name[2]);
                            Console.SetCursorPosition(0, 1);
                            Console.WriteLine(text2[0]);
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine(text[2]);
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine(date);
                            Console.SetCursorPosition(0, cursor = 4);
                        }
                        if ((key.Key == ConsoleKey.Enter) && (cursor == 2))
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine(name[3]);
                            Console.SetCursorPosition(0, 1);
                            Console.WriteLine(text2[0]);
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine(text[3]);
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine(date);
                            Console.SetCursorPosition(0, cursor = 4);
                        }
                        else
                        {
                            Menu();
                            Menu2();
                        }
                        break;
                    case 308:
                        if ((key.Key == ConsoleKey.Enter) && (cursor == 1))
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine(name[4]);
                            Console.SetCursorPosition(0, 1);
                            Console.WriteLine(text2[0]);
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine(text[4]);
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine(date);
                            Console.SetCursorPosition(0, cursor = 4);
                        }
                        else
                        {
                            Menu();
                            Menu2();
                        }
                        break;
                    default:
                        Menu();
                        Menu2();
                        break;
                }
            }
        }
    }
}
