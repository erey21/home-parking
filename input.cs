using System;
using System.Collections.Generic;
using System.Text;

namespace home_parking
{
    class input
    {
        //получение целых чисел
        public static int get_int(string s)
        {
            int n;
            try
            {
                Console.Write($"Введите {s}: ");
                return n = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Введите только цельночисленное значение!\n");
                Console.ForegroundColor = ConsoleColor.White;
                return get_int(s);
            }
        }

        //получение строки
        public static string get_str(string s) {
            Console.Write($"Введите {s}: ");
            string str = Console.ReadLine();
            return str;

        }

        public static List<machine> fill_list(int count)
        {
            int n = 1;
            List<machine> fill_list = new List<machine>();

            for (int i = 0; i < count; i++) {
                machine car = new machine();
                car.nomer_region = new Dictionary<string, int>();

                car.marka = get_str($"марку {n} авто");
                car.model = get_str($"модель {n} авто");
                car.color = get_str($"цвет {n} авто");
                car.nomer_region.Add(get_str($"номер {n} авто"), get_int($"регион {n} авто"));
                fill_list.Add(car);
                Console.WriteLine();
                n++;
            }

            return fill_list;
        }

        public static int park_count()
        {
            int n;
            return n = get_int("количество парковочных мест");
        }
    }

}
