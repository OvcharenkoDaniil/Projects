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

           

            Console.ReadKey();

        }
    }
}
