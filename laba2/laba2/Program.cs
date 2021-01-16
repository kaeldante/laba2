/*
 * Создано в SharpDevelop.
 * Пользователь: 123
 * Дата: 16.01.2021
 * Время: 11:17
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace laba2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("ВАРИАНТ 7 (порядковый номер 32): Запрашивает у пользователя радиус и выводит площадь круга:");
			const double PI = 3.1415926535;
			Console.WriteLine("Число Пи = 3.1415926535");
			Console.Write("Введите радиус круга: ");
		
	
			double r = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("S= " + PI * r * r);
			

			
				
				Console.WriteLine("Нажмите любую клавишу для выхода");
			Console.ReadKey();
			
			
		}
	}
}