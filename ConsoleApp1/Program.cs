using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.Write("x=");
            //    int x = int.Parse(Console.ReadLine());
            //    int y = x < 0 ? x + 1 : x - 1;
            //    Console.WriteLine($"y={y}");
            //    Console.ReadLine();
            //}
            //catch
            //{ 
            //}

            //Задание 1
            //Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            //Random rnd = new Random();
            //int chislo = rnd.Next(10,99);
            //Console.WriteLine($"рандомное число = {chislo}");
            //string x = chislo % 2 == 0 ? "число четное" : "число не четное";
            //Console.WriteLine($"x={x}");

            //Зaдание 2
            //try
            //{
            //    // Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
            //    Console.Write("Введите номер дня недели:");
            //    int day = int.Parse(Console.ReadLine());
            //    switch (day)
            //    {
            //        case 1: Console.WriteLine("Понедельник"); break;
            //        case 2: Console.WriteLine("Вторник"); break;
            //        case 3: Console.WriteLine("Среда"); break;
            //        case 4: Console.WriteLine("Четверг"); break;
            //        case 5: Console.WriteLine("Пятница"); break;
            //        case 6: Console.WriteLine("Суббота"); break;
            //        case 7: Console.WriteLine("Воскресенье"); break;
            //        default: Console.WriteLine("Нет такого дня недели"); break;
            //    }
            //}
            //catch
            //{
            //}
            //Console.ReadLine();

            //Задача 3 Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.
            //Random rnd = new Random();
            //int day = rnd.Next(1,7);
            //Console.WriteLine($"день недели = {day}");
            //switch (day)
            //{
            //    case 1: Console.WriteLine("Понедельник"); break;
            //    case 2: Console.WriteLine("Вторник"); break;
            //    case 3: Console.WriteLine("Среда"); break;
            //    case 4: Console.WriteLine("Четверг"); break;
            //    case 5: Console.WriteLine("Пятница"); break;
            //    case 6: Console.WriteLine("Суббота"); break;
            //    case 7: Console.WriteLine("Воскресенье"); break;
            //}

            //Задача 4
            //try
            //{
            //    //По номеру месяца вывести название времени года.
            //    Console.Write("Введите номер месяца:");
            //    int month = int.Parse(Console.ReadLine());
            //    switch (month)
            //    {
            //        case 1: Console.WriteLine("зима"); break;
            //        case 2: Console.WriteLine("зима"); break;
            //        case 3: Console.WriteLine("весна"); break;
            //        case 4: Console.WriteLine("весна"); break;
            //        case 5: Console.WriteLine("весна"); break;
            //        case 6: Console.WriteLine("лето"); break;
            //        case 7: Console.WriteLine("лето"); break;
            //        case 8: Console.WriteLine("лето"); break;
            //        case 9: Console.WriteLine("осень"); break;
            //        case 10: Console.WriteLine("осень"); break;
            //        case 11: Console.WriteLine("осень"); break;
            //        case 12: Console.WriteLine("зима"); break;
            //        default: Console.WriteLine("Нет такого времени года"); break;
            //    }
            //}
            //catch { }
            //Console.ReadLine();

            //Задание 5
            //try
            //{
            //    // Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд. Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
            //    Console.Write("Введите транспорт:");
            //    char tran = char.Parse(Console.ReadLine());
            //    switch (tran)
            //    {
            //        case 'а': Console.WriteLine("Скорость автомобиля = 400км/ч"); break;
            //        case 'в': Console.WriteLine("Скорость велосипеда = 40 км/ч"); break;
            //        case 'м': Console.WriteLine("Скорость мотоцикла = 500км/ч"); break;
            //        case 'с': Console.WriteLine("Скорость самолета = 1000км/ч"); break;
            //        case 'п': Console.WriteLine("Скорость поезда = 90км/ч"); break;
            //        default: Console.WriteLine("Ошибка"); break;
            //    }
            //}
            //catch { }
            //Console.ReadLine();

            //Задание 6
            //try
            //{
            //    //Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
            //    Console.WriteLine("Введите урок:");
            //    char tran = char.Parse(Console.ReadLine());
            //    switch (tran)
            //    {
            //        case 'ф': Console.WriteLine("Физика"); break;
            //        case 'м': Console.WriteLine("Математика"); break;
            //        case 'и': Console.WriteLine("История"); break;
            //        case 'г': Console.WriteLine("География"); break;
            //        case 'б': Console.WriteLine("Биология"); break;
            //        default: Console.WriteLine("Ошибка"); break;
            //    }
            //}
            //catch { }
            //Console.ReadLine();

            Random rnd = new Random();
            int ball = rnd.Next(0,100);
            Console.WriteLine($"{ball}");
            int mark = 0;
            if (ball >= 90 && ball <= 100) 
            {
                mark = 5;

            }
             else if (ball >= 70 && ball <= 89)
            {
                 mark = 4;
            }
             else if (ball >= 50 && ball <= 69)
            {
                mark = 3;
            }
            else if (ball < 50)
            {
                mark = 2;
            }
            Console.WriteLine($"оценка = {mark}");
            switch(mark)
            {
                case 5: Console.WriteLine("отлично"); break;
                case 4: Console.WriteLine("Хорошо"); break;
                case 3: Console.WriteLine("Удовлетворительно"); break;
                case 2: Console.WriteLine("Плохо"); break;
                default: Console.WriteLine(""); break;
            }



            //Console.WriteLine("введите признак фигуры" );
            //char fig = char.Parse( Console.ReadLine() );
            //double p;
            //double s;
            //double pp;
            //switch(fig)
            //{
            //    case 'К':
            //    case 'к':
            //        Console.WriteLine("введите радиус");
            //        double r = double.Parse( Console.ReadLine() );
            //        s = Math.PI * Math.Pow(r, 2);
            //        p = 2*Math.PI*r;
            //        Console.WriteLine($"s={s}, p={p}"); break;
            //    case 'П':
            //    case 'п':
            //        Console.WriteLine("введите ширину");
            //        double width = double.Parse(Console.ReadLine());
            //        Console.WriteLine("введите высоту");
            //        double height = double.Parse(Console.ReadLine());
            //        s = width * height;
            //        p = 2 * (width * height);
            //        Console.WriteLine($"s={s}, p={p}"); break;
            //    case 'Т':
            //    case 'т':
            //        Console.WriteLine("введите 1 сторону");
            //        double a = double.Parse(Console.ReadLine());
            //        Console.WriteLine("введите 2 сторону");
            //        double b = double.Parse(Console.ReadLine());
            //        Console.WriteLine("введите 3 сторону");
            //        double c = double.Parse(Console.ReadLine());
            //        p = a + b + c;
            //        pp = (a + b + c) / 2;
            //        s = Math.Sqrt(pp * (pp-a)*(pp-b)*(pp-c));
            //        Console.WriteLine($"s={s}, p={p}"); break;
            //        default: Console.WriteLine("нет ответа");break;
            //}





        }
        }
}
