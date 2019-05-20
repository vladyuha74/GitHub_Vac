using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_74
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массив который имеет числа их количество равно 10
            int[] array = { 4, 0, 3, 19, 492, -10, 45, 89, 1, 7 };
            int min_chislo1 =1000000; // Дам саоме больше значение которого нет в массиве
            int min_chislo2 = 1000000; // Дам саоме больше значение которого нет в массиве
            int summa = 0; //Переменная для суммы двух чисел
            for (int i=0; i < array.Length; i++) // Ищем первое число.
            {
                if (array[i] < min_chislo1)
                {
                    min_chislo1 = array[i];
                }  
            }

            //Ищем второе число. 
            for (int j=0; j < array.Length; j++) //Ищем второе число.
            {
                // Минимальное 1 число исключаем и задаем условие чтобы сравнивалось минимальным вторым числом.
                if ((array[j] < min_chislo2) & (array[j] != min_chislo1))
                {
                    if (min_chislo2 > min_chislo1)
                    {
                        min_chislo2 = array[j];
                    }
                }
            }
            // Сумируем минимальные числа
            summa = min_chislo1 + min_chislo2;
            string symv = "+"; //Символ который будет показываться прир выводе
            if (min_chislo2 < 0)
            {
                Console.WriteLine("Итого: " + min_chislo1 + min_chislo2 + "=" + summa);
            }
            else
            {
                Console.WriteLine("Итого: " + min_chislo1 + symv + min_chislo2 + "=" + summa); // В итоге должно быть -10+0 = -10
            }
            // В итоге должно быть -10+0 = -10
            Console.ReadKey();
        }
    }
}
