
using zakaz;

namespace tortek
{

    internal class menuha
    {

        static void Main()
        {
            List<string> list = new List<string>() { "0", "", "0", "" };
            menuha adres = new menuha();
            adres.Man(list);
        }
        public void Man(List<string> spisok)
        {

            int sum = Convert.ToInt32(spisok[0]) + Convert.ToInt32(spisok[2]);
            string things = spisok[1] + spisok[3];
            spisok[3] = things;
            spisok[2] = Convert.ToString(sum);
            punkti vibor = new punkti();
            int pozition = 1;
            string path = "C:\\Users\\geday\\OneDrive\\Рабочий стол\\Чеки.txt";
            if (File.Exists(path) == false)
            {
                File.Create(path);
            }


            string[] cheki = File.ReadAllLines(path);

            int ch = cheki.Length;

            string[] cheki2 = new string[cheki.Length + 1];
            int ch2 = cheki2.Length;
            for (int i = 0; i < ch;)
            {
                cheki2[ch2 - 1] = cheki[ch - 1];
                ch2--; ch--;
            }


            Console.WriteLine("для своего торта вы можете выбрать форму, декорации, размер, начинку, глазурь и количество коржей");
            Console.WriteLine("\tформа торта\n\tдекорации для торта\n\tразмер торта\n\tначинка торта\n\tглазурь для торта\n\tколичество коржей для торта\n\tоформить заказ\nобщая стоимость: " + sum + " Эдди \nингридиенты: " + things);
            Console.SetCursorPosition(0, pozition);
            Console.WriteLine("-->");
            ConsoleKeyInfo Clavisha = Console.ReadKey();
            Console.Clear();
            while (Clavisha.Key != ConsoleKey.Enter)
            {

                if (Clavisha.Key == ConsoleKey.UpArrow)
                {
                    pozition--;
                }
                if (Clavisha.Key == ConsoleKey.DownArrow)
                {
                    pozition++;
                }
                if (pozition > 7)
                {
                    pozition = 1;
                }
                if (pozition < 1)
                {
                    pozition = 7;
                }
                Console.WriteLine("для своего торта вы можете выбрать форму, декорации, размер, начинку, глазурь и количество коржей");
                Console.WriteLine("\tформа торта\n\tдекорации для торта\n\tразмер торта\n\tначинка торта\n\tглазурь для торта\n\tколичество коржей для торта\n\tоформить заказ\nобщая стоимость: " + sum + " Эдди\nингридиенты: " + things);
                Console.SetCursorPosition(0, pozition);
                Console.WriteLine("-->");
                Clavisha = Console.ReadKey();
                Console.Clear();
            }
            Convert.ToString(spisok[0]);
            Convert.ToString(spisok[2]);
            if (pozition == 1)
            {
                vibor.form(spisok);
            }
            if (pozition == 2)
            {
                vibor.decoration(spisok);
            }
            if (pozition == 3)
            {
                vibor.size(spisok);
            }
            if (pozition == 4)
            {
                vibor.vkus(spisok);
            }
            if (pozition == 5)
            {
                vibor.glasuur(spisok);
            }
            if (pozition == 6)
            {
                vibor.quntity(spisok);
            }
            if (pozition == 7)
            {

                cheki2[0] = DateTime.Now + "\nОбщая стоимость:" + spisok[2] + " эдди. \n\t\tВсе Ингредиенты:" + things;
                File.WriteAllLines(path, cheki2);
                int cursor = 1;
                Console.WriteLine("Ваш заказ оформлен, спасибо, что выбрали нас. Хотите оформить еще один заказ?\n\tда\n\tнет");
                Console.SetCursorPosition(0, cursor);
                Console.WriteLine("-->");
                ConsoleKeyInfo Clavishu = Console.ReadKey();
                Console.Clear();
                while (Clavishu.Key != ConsoleKey.Enter)
                {

                    if (Clavishu.Key == ConsoleKey.UpArrow)
                    {
                        cursor--;
                    }
                    if (Clavishu.Key == ConsoleKey.DownArrow)
                    {
                        cursor++;
                    }
                    if (cursor > 2)
                    {
                        cursor = 1;
                    }
                    if (cursor < 1)
                    {
                        cursor = 2;
                    }
                    Console.WriteLine("Ваш заказ оформлен, спасибо, что выбрали нас. Хотите оформить еще один заказ?\n\tда\n\tнет");
                    Console.SetCursorPosition(0, cursor);
                    Console.WriteLine("-->");
                    Clavishu = Console.ReadKey();
                    Console.Clear();
                }
                if (cursor == 1)
                {
                    List<string> list = new List<string>() { "0", "", "0", "" };
                    menuha adres = new menuha();
                    adres.Man(list);
                }
            }
        }
    }
}