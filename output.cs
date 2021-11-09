using System;
using System.Collections.Generic;
using System.Text;

namespace home_parking
{
    class output
    {
        public static void write_list(List<machine> list_1)
        {
            foreach (var i in list_1)
            {
                Console.Write(i.marka + " " + i.model + " " + i.color);
                Console.WriteLine();
            }

        }

        public static int ans_blue(List<machine> list) {
            int b_count = 0;
            foreach (var i in list)
            {
                switch (i.color.ToLower()) {
                    case "blue":
                    case "синий":
                    case "синяя":
                        b_count++;
                        break;
                }
            }
            return b_count;
        }

        public static int ans_red(List<machine> list) {
            int r_count = 0;
            foreach (var i in list)
            {
                switch (i.color.ToLower()) {
                    case "red":
                    case "красный":
                    case "красная":
                        r_count++;
                        break;
                }
            }

            return r_count;

        }
        public static int park_count = input.get_int("количество парковочных мест");
        static List<machine> parking_list = input.fill_list(park_count);

        public static void ans() {
            Console.WriteLine($"Количество синих машин на парковке = {ans_blue(parking_list)}.\nКоличество красных машин на парковке = {ans_red(parking_list)}.");
        }
    }
}
