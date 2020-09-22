using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool bool_value;
            byte byte_value;
            sbyte sbyte_value;
            char char_value;
            string string_value;
            float float_value;
            decimal decimal_value;
            double double_value;
            int int_value;
            uint uint_value;
            long long_value;
            ulong ulong_value;
            short short_value;
            ushort ushort_value;






            Console.WriteLine("Введите переменную типа int ");
            int_value = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа uint ");
            uint_value = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа float");
            float_value = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа double");
            double_value = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа bool (true/false)");
            bool_value = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа decimal");
            decimal_value = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа byte");
            byte_value = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа sbyte");
            sbyte_value = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа char");
            char_value = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа string");
            string_value = Console.ReadLine();
            Console.WriteLine("Введите переменную типа short");
            short_value = short.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа ushort");
            ushort_value = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа long");
            long_value = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную типа ulong");
            ulong_value = ulong.Parse(Console.ReadLine());

            Console.WriteLine($"Переменная типа int: {int_value}");
            Console.WriteLine($"Переменная типа uint: {uint_value}");
            Console.WriteLine($"Переменная типа float: {float_value}");
            Console.WriteLine($"Переменная типа double: {double_value}");
            Console.WriteLine($"Переменная типа bool: {bool_value}");
            Console.WriteLine($"Переменная типа decimal: {decimal_value}");
            Console.WriteLine($"Переменная типа byte: {byte_value}");
            Console.WriteLine($"Переменная типа sbyte: {sbyte_value}");
            Console.WriteLine($"Переменная типа char: {char_value}");
            Console.WriteLine($"Переменная типа string: {string_value}");
            Console.WriteLine($"Переменная типа short: {short_value}");
            Console.WriteLine($"Переменная типа ushort: {ushort_value}");
            Console.WriteLine($"Переменная типа long: {long_value}");
            Console.WriteLine($"Переменная типа ulong: {ulong_value}");
            Console.WriteLine();

            Console.WriteLine("Неявное приведение типов: ");
            long_value = int_value;
            int_value = short_value;
            uint_value = ushort_value;
            float_value = byte_value;
            double_value = sbyte_value;
            Console.WriteLine("1.Неявное приведение int к long: long_value = int_value");
            Console.WriteLine("2.Неявное приведение ushort к uint: uint_value = ushort_value");
            Console.WriteLine("3.Неявное приведение short к int: int_value = short_value ");
            Console.WriteLine("4.Неявное приведение byte к float: float_value = byte_value");
            Console.WriteLine("5.Неявное приведение sbyte к double:  double_value = sbyte_value");
            Console.WriteLine();

            Console.WriteLine($" Переменная типа long имеет значение: {long_value}");
            Console.WriteLine($" Переменная типа uint имеет значение: {uint_value}");
            Console.WriteLine($" Переменная типа int имеет значение: {int_value}");
            Console.WriteLine($" Переменная типа float имеет значение: {float_value}");
            Console.WriteLine($" Переменная типа double имеет значение: {double_value}");
            Console.WriteLine();

            Console.WriteLine("Явное приведение типов: ");
            ulong_value = (ulong)uint_value;
            byte_value = (byte)char_value;
            double_value = (double)float_value;
            decimal_value = (decimal)ushort_value;
            long_value = (long)sbyte_value;

            Console.WriteLine("1.Явное приведение uint к ulong: ulong_value = (ulong)uint_value");
            Console.WriteLine("2.Явное приведение char к byte: byte_value = (byte)char_value");
            Console.WriteLine("3.Явное приведение float к double: double_value = (double)float_value ");
            Console.WriteLine("4.Явное приведение ushort к decimal: decimal_value = (decimal)ushort_value");
            Console.WriteLine("5.Явное приведение sbyte к long:  long_value = (long)sbyte_value");
            Console.WriteLine();

            Console.WriteLine($" Переменная типа ulong имеет значение: {ulong_value}");
            Console.WriteLine($" Переменная типа byte имеет значение: {byte_value}");
            Console.WriteLine($" Переменная типа double имеет значение: {double_value}");
            Console.WriteLine($" Переменная типа decimal имеет значение: {decimal_value}");
            Console.WriteLine($" Переменная типа long имеет значение: {long_value}");
            Console.WriteLine();

            
            Console.WriteLine("Упаковка и распаковка значимых типов: ");
            object new_object = uint_value;
            Console.WriteLine($"Упаковка: {new_object}");
            uint_value = (uint)new_object;
            Console.WriteLine($"Распаковка: {uint_value}");
            Console.WriteLine();

            Console.WriteLine("Неявно типизированная переменная");
            var variable = 10.2m;
            Console.WriteLine($"Неявно типизированная переменная с помощью ключевого слова var {variable}");
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
