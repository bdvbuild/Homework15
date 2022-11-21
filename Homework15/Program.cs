using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

//метод void SetStart(int x) -устанавливает начальное значение
//метод int GetNext() -возвращает следующее число ряда
//метод void Reset() -выполняет сброс к начальному значению

//Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
//В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.

namespace Homework15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression progression1 = new ArithProgression();
            Console.WriteLine("--------------------------\nАрифметическая прогрессия");
            progression1.SetStart(10);
            progression1.SetStep(2);
            Console.WriteLine(progression1.GetNext());
            Console.WriteLine(progression1.GetNext());
            Console.WriteLine(progression1.GetNext());
            progression1.Reset();
            Console.WriteLine(progression1.GetNext());
            Console.WriteLine(progression1.GetNext());


            GeomProgression progression2 = new GeomProgression();
            Console.Write("--------------------------\nГеометрическая прогрессия\nВведите стартовое число:");
            progression2.SetStart(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Введите шаг прогрессии: ");
            progression2.SetStep(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Необходимое количество чисел: ");
            int i = Convert.ToInt32(Console.ReadLine());
            while (i!=0) 
            {
                Console.Write($"{progression2.GetNext()} ");
                i -= 1;
            }

            Console.ReadLine();
        }
    }
}
