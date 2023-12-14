using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Задача 1.Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.

                //Random random = new Random();
                //int number = random.Next(10, 99);
                //Console.WriteLine(number);
                //string str = (number % 2 == 0) ? "четное" : "нечетное";
                //Console.WriteLine(str);

                //Задача 2.Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.

                //Random random = new Random();
                //int number = random.Next(1, 7);
                //Console.WriteLine(number);
                //switch (number)
                //{
                //    case 1:
                //        Console.WriteLine("понедельник"); break;
                //    case 2:
                //        Console.WriteLine("вторник"); break;
                //    case 3:
                //        Console.WriteLine("среда"); break;
                //    case 4:
                //        Console.WriteLine("четверг"); break;
                //    case 5:
                //        Console.WriteLine("пятница"); break;
                //    case 6:
                //        Console.WriteLine("суббота"); break;
                //    case 7:
                //        Console.WriteLine("воскресенье"); break;

                //}

                //Задача 3.Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя
                //бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.

                //Console.WriteLine("Введите три целых положителных числа: ");
                //int num1 = int.Parse(Console.ReadLine());
                //int num2 = int.Parse(Console.ReadLine());
                //int num3 = int.Parse(Console.ReadLine());

                //if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0)
                //{
                //    num1 /= 2;
                //    num2 /= 2;
                //    num3 /= 2;
                //}
                //else if (num1 % 2 == 0 || num2 % 2 == 0 || num3 % 2 == 0)
                //{
                //    num1 *= 2;
                //    num2 *= 2;
                //    num3 *= 2;
                //}
                //else
                //{
                //    num1++;
                //    num2++;
                //    num3++;
                //}
                //Console.WriteLine($"{num1} \t {num2} \t {num3}");

                //Задача 4.Проведен тест, оцениваемый в целочисленных баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости
                //от набранного количества баллов: от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».

                //Console.WriteLine("Введите количество баллов: ");
                //int mark = int.Parse(Console.ReadLine());
                //if (mark <= 100 && mark >= 90)
                //{
                //    Console.WriteLine("отлично");
                //}
                //else if (mark <= 89 && mark >= 70)
                //{
                //    Console.WriteLine("хорошо");
                //}
                //else if (mark <= 69 && mark >= 50)
                //{
                //    Console.WriteLine("удовлетворительно");
                //}
                //else
                //{
                //    Console.WriteLine("неудовлетворительно");
                //}


                //Задача 5.Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник.
                //Вывести на экран периметр и площадь заданной фигуры(данные, необходимые для расчетов, запросить у пользователя).

                //Console.WriteLine("Введите признак геометрической фигуры на плоскости: ");
                //char shapes = char.Parse(Console.ReadLine());
                //double perimeter, square, r, a, b, c, h;
                //switch (shapes)
                //{
                //    case 'к':
                //        Console.WriteLine("Введите радиус круга: ");
                //        r = double.Parse(Console.ReadLine());
                //        perimeter = 2 * Math.PI * r;
                //        square = Math.PI * Math.Pow(r, 2);
                //        Console.WriteLine(perimeter);
                //        Console.WriteLine(square);
                //        break;
                //    case 'п':
                //        Console.WriteLine("Введите длину прямоугольника: ");
                //        Console.Write("a = ");
                //        a = double.Parse(Console.ReadLine());
                //        Console.WriteLine("Введите ширину прямоугольника: ");
                //        Console.Write("b = ");
                //        b = double.Parse(Console.ReadLine());
                //        perimeter = (a + b) * 2;
                //        square = a * b;
                //        Console.WriteLine(perimeter);
                //        Console.WriteLine(square);
                //        break;
                //    case 'т':
                //        Console.WriteLine("Введите стороны треугольника: ");
                //        Console.Write("a = ");
                //        a = double.Parse(Console.ReadLine());
                //        Console.Write("b = ");
                //        b = double.Parse(Console.ReadLine());
                //        Console.Write("с = ");
                //        c = double.Parse(Console.ReadLine());
                //        Console.Write("высота: ");
                //        h = double.Parse(Console.ReadLine());
                //        perimeter = a + b + c;
                //        square = (a * h) / 2;
                //        Console.WriteLine(perimeter);
                //        Console.WriteLine(square);
                //        break;
                //}

                //Задача 6.Написать приложение, которое позволяет вычислить сумму страхового взноса(SV) для автомобиля.
                //Входные данные будут вводиться с клавиатуры:
                Console.Write("марка автомобиля - ");
                string ma = Console.ReadLine();
                Console.Write("Срок страхования(от 1 до 12 месяцев) - ");
                int month = int.Parse(Console.ReadLine());
                double sum, kt = 0;

                if (month < 3)
                {
                    kt = 10;
                }
                else if (month >= 3 && month < 6)
                {
                    kt = 8;
                }
                else if (month >= 6 && month < 12)
                {
                    kt = 5;
                }
                else
                {
                    Console.WriteLine("Неверное число месяцев");
                }
                sum = 50 * month * ((1 + kt) / 100);

                Console.WriteLine($"Ваш автомобиль марки {ma} был застрахован");
                Console.WriteLine($"Сумма страхового взноса составила {sum}.");

                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }

        }
    }
}
