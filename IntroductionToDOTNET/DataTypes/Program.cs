//#define DATA_TYPES
//#define CONSTANTS
#define TYPE_CONVERSIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		const string delimiter = "\n----------------------------------\n";
		static void Main(string[] args)
		{
#if DATA_TYPES
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвертка Boolean;");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));
			Console.WriteLine(delimiter);
			bool rain = true;
			Console.WriteLine($"Дождь идет? - {rain}");

			////////////////////////////////////////////////////////////////////////////////////////

			Console.WriteLine
				(
$@"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значения в диапазоне
от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвертка - {typeof(char)}"
				);
			Console.WriteLine(delimiter);
			Console.WriteLine
				(
@"RAW-строка - игнорирует все специальные символы и Esc-последовательности \t\n,
т.е., востпринимается как есть 'as-is'"
				);
			Console.WriteLine(delimiter);

			////////////////////////////////////////////////////////////////////////////////////////
			//ushort, uint, ulong
			//sbyte (Signed Byte)
			//sbyte		byte	1 Байт
			//short		ushort	2 Байта
			//int		uint	4 Байта
			//long		ulong	8 Байт
			Console.WriteLine
				(
$@"byte занимает {sizeof(byte)} Байт памяти, 
и принимает значения в диапазоне от {byte.MinValue} до {byte.MaxValue},
класс-обвертка {typeof(byte)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"sbyte занимает {sizeof(sbyte)} Байт памяти, 
и принимает значения в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue},
класс-обвертка {typeof(sbyte)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine($@"decimal заниамет {sizeof(decimal)} Байт памяти");
			decimal a = 1;
			a /= 3;
			Console.WriteLine(a);
			a *= 3;
			Console.WriteLine(a);
#endif

			///////////////////////////////////////////////////////////////////////////

#if CONSTANTS
			Console.WriteLine("Hello".GetType());
			//Console.WriteLine(typeof("Hello"));
			Console.WriteLine(5.0.GetType()); 
#endif
#if TYPE_CONVERSIONS
			int n = 5;
			while (n-- > 0)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine(delimiter);
			//ushort b = (ushort)-2;
			//Console.WriteLine(b); 
			double a = 2.2;
			short b = (short)a;
			Console.WriteLine(b);
			//C-Like notation	(type)value
			//bool rain = Convert.ToBoolean("True");
			bool rain = bool.Parse("FaLsE");
			//Console.WriteLine(rain as string);

#endif
		}
	}
}
