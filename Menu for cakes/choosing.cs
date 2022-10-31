using tortek;

namespace zakaz
{
    internal class punkti
    {
        public void form(List<string> forms)
        {

            int pozition = 1;
            Console.WriteLine("форма коржей:");
            Console.WriteLine("\tквадрат: 100 Эдди\n\tпрямоугольник: 100 Эдди\n\tпирамидка: 200 Эдди");
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
                if (pozition > 3)
                {
                    pozition = 1;
                }
                if (pozition < 1)
                {
                    pozition = 3;
                }
                Console.WriteLine("форма коржей:");
                Console.WriteLine("\tквадрат: 100 Эдди\n\tпрямоугольник: 100 Эдди\n\tпирамидка: 200 Эдди");
                Console.SetCursorPosition(0, pozition);
                Console.WriteLine("-->");
                Clavisha = Console.ReadKey();
                Console.Clear();
            }
            if (pozition == 1)
            {
                forms[0] = "100";
                forms[1] = "квадрат: 100 Эдди; ";
            }
            if (pozition == 2)
            {
                forms[0] = "100";
                forms[1] = "прямоугольник: 100 Эдди; ";
            }
            if (pozition == 3)
            {
                forms[0] = "200";
                forms[1] = "пирамидка: 200 Эдди; ";
            }
            menuha back = new menuha();
            back.Man(forms);
        }
        public void size(List<string> forms)
        {
            int pozition = 1;
            Console.WriteLine("размер:");
            Console.WriteLine("\t10 сантиметров: 100 Эдди\n\t20 сантиметров: 200 Эдди\n\t30 сантиметров: 300 Эдди");
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
                if (pozition > 3)
                {
                    pozition = 1;
                }
                if (pozition < 1)
                {
                    pozition = 3;
                }
                Console.WriteLine("размер:");
                Console.WriteLine("\t10 сантиметров: 100 Эдди\n\t20 сантиметров: 200 Эдди\n\t30 сантиметров: 300 Эдди");
                Console.SetCursorPosition(0, pozition);
                Console.WriteLine("-->");
                Clavisha = Console.ReadKey();
                Console.Clear();
            }
            if (pozition == 1)
            {
                forms[0] = "100";
                forms[1] = "10 сантиметров: 100 Эдди; ";
            }
            if (pozition == 2)
            {
                forms[0] = "200";
                forms[1] = "20 сантиметров: 200 Ждди; ";
            }
            if (pozition == 3)
            {
                forms[0] = "300";
                forms[1] = "30 сантиметров: 300 Эдди; ";
            }
            menuha back = new menuha();
            back.Man(forms);
        }
        public void decoration(List<string> forms)
        {
            int pozition = 1;
            Console.WriteLine("декорации:");
            Console.WriteLine("\tфото именинника 100 Эдди\n\tколизей 200 Эдди\n\tуголь 300 Эдди");
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
                if (pozition > 3)
                {
                    pozition = 1;
                }
                if (pozition < 1)
                {
                    pozition = 3;
                }
                Console.WriteLine("декорации:");
                Console.WriteLine("\tфото именинника 100 Эдди\n\tколизей 200 Эдди\n\tуголь 300 Эдди");
                Console.SetCursorPosition(0, pozition);
                Console.WriteLine("-->");
                Clavisha = Console.ReadKey();
                Console.Clear();
            }

            if (pozition == 1)
            {
                forms[0] = "100";
                forms[1] = "фото именинника 100 Эдди; ";
            }
            if (pozition == 2)
            {
                forms[0] = "200";
                forms[1] = "колизей 200 Эдди; ";
            }
            if (pozition == 3)
            {
                forms[0] = "300";
                forms[1] = "уголь 300 Эдди; ";
            }
            menuha back = new menuha();
            back.Man(forms);
        }
        public void vkus(List<string> forms)
        {
            int pozition = 1;
            Console.WriteLine("начинка:");
            Console.WriteLine("\tначинка киви: 100 Эдди\n\tначинка сливки: 200 Эдди\n\tначинка памело: 300 Эдди");
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
                if (pozition > 3)
                {
                    pozition = 1;
                }
                if (pozition < 1)
                {
                    pozition = 3;
                }
                Console.WriteLine("начинка:");
                Console.WriteLine("\tначинка киви: 100 Эдди\n\tначинка сливки: 200 Эдди\n\tначинка памело: 300 Эдди");
                Console.SetCursorPosition(0, pozition);
                Console.WriteLine("-->");
                Clavisha = Console.ReadKey();
                Console.Clear();
            }
            if (pozition == 1)
            {
                forms[0] = "100";
                forms[1] = "начинка киви: 100 Эдди; ";
            }
            if (pozition == 2)
            {
                forms[0] = "200";
                forms[1] = "начинка сливки: 200 Эдди; ";
            }
            if (pozition == 3)
            {
                forms[0] = "300";
                forms[1] = "начинка памело: 300 Эдди; ";
            }
            menuha back = new menuha();
            back.Man(forms);
        }
        public void quntity(List<string> forms)
        {
            int pozition = 1;
            Console.WriteLine("количество коржей:");
            Console.WriteLine("\tодин корж: 100 Эдди\n\tдва коржа: 200 Эдди\n\tтри коржа: 300 Эдди");
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
                if (pozition > 3)
                {
                    pozition = 1;
                }
                if (pozition < 1)
                {
                    pozition = 3;
                }
                Console.WriteLine("количество коржей:");
                Console.WriteLine("\tодин корж: 100 Эдди\n\tдва коржа: 200 Эдди\n\tтри коржа: 300 Эдди");
                Console.SetCursorPosition(0, pozition);
                Console.WriteLine("-->");
                Clavisha = Console.ReadKey();
                Console.Clear();
            }
            if (pozition == 1)
            {
                forms[0] = "100";
                forms[1] = "один корж: 100 Эдди; ";
            }
            if (pozition == 2)
            {
                forms[0] = "200";
                forms[1] = "два коржа: 200 Эдди; ";
            }
            if (pozition == 3)
            {
                forms[0] = "300";
                forms[1] = "три коржа: 300 Эдди; ";
            }
            menuha back = new menuha();
            back.Man(forms);
        }
        public void glasuur(List<string> forms)
        {
            int pozition = 1;
            Console.WriteLine("глазурь:");
            Console.WriteLine("\tклубничная глазурь: 100 Эдди\n\tшоколадная глазурь: 200 Эдди\n\tкарамельная глазурь: 300 Эдди");
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
                if (pozition > 3)
                {
                    pozition = 1;
                }
                if (pozition < 1)
                {
                    pozition = 3;
                }
                Console.WriteLine("глазурь:");
                Console.WriteLine("\tклубничная глазурь: 100 Эдди\n\tшоколадная глазурь: 200 Эдди\n\tкарамельная глазурь: 300 Эдди");
                Console.SetCursorPosition(0, pozition);
                Console.WriteLine("-->");
                Clavisha = Console.ReadKey();
                Console.Clear();
            }
            if (pozition == 1)
            {
                forms[0] = "100";
                forms[1] = "клубничная глазурь: 100 Эдди; ";
            }
            if (pozition == 2)
            {
                forms[0] = "200";
                forms[1] = "шоколадная глазурь: 200 Эдди; ";
            }
            if (pozition == 3)
            {
                forms[0] = "300";
                forms[1] = "карамельная глазурь: 300 Эдди; ";
            }
            menuha back = new menuha();
            back.Man(forms);
        }
    }
}