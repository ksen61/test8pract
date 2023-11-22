namespace Pract8
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "TablicaRecordov.json";
            TablicaRekordov.Load(fileName);
            string text = "Дремотное жужжание пчел, то пробивавших себе дорогу в нескошенной высокой траве, то с однообразной настойчивостью кружившихся над пыльными, золочеными усиками вьющейся лесной мальвы, как будто делали тишину еще более тягостной. Глухой гул Лондона доносился сюда, как басовые ноты далекого органа. Посреди комнаты на мольберте стоял портрет молодого человека необыкновенной красоты во весь рост, а перед ним, немного поодаль, сидел и сам художник, Бэзиль Холлуорд, внезапное исчезновение которого несколько лет тому назад вызвало в обществе так много шуму и возбудило немало странных толков.";
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите имя для таблицы рекордов:");
                string name = Console.ReadLine();
                while (string.IsNullOrEmpty(name))
                {
                    Console.SetCursorPosition(0, 1);
                    name = Console.ReadLine();
                }
                User user = new User(name, 0, 0);
                Text nabor = new Text(user, text, ConsoleColor.DarkMagenta);
                nabor.Start();
                TablicaRekordov.UpdateUser(user);
                TablicaRekordov.Save(fileName);
                TablicaRekordov.Show();
                Console.WriteLine();
                Console.WriteLine("Чтобы попробовать еще раз, нажмите Enter");
                key = Console.ReadKey(true);
            } while (key.Key == ConsoleKey.Enter);
        }
    }
}