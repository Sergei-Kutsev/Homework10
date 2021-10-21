using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
   
    public class Program
    {
        static void Main(string[] args)
        {
			Angle angle = new Angle();
			try
			{
				Console.Write("Целочисленное значение угла в градусах = ");
				angle.Grad = Convert.ToInt32(Console.ReadLine());

				Console.Write("Минуты угла: ");
				angle.Min = Convert.ToInt32(Console.ReadLine());

				Console.Write("Секунды угла: ");
				angle.Sec = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Неверный формат ввода.");
				Console.ReadKey();
				return;
			}
			angle.GetToRadians();
		}
	}
	public class Angle
	{
		int grad;
		int min;
		int sec;

		public int Grad
		{
			set
			{
				if (value >= 0 && value <= 180)
				{
					grad = value;
				}
				else
				{
					Console.WriteLine("Введите целочисленное значение угла в градусах в диапазоне [0,180]");
					Console.ReadKey();
					Environment.Exit(0);
				}
			}
			get
			{
				return grad;
			}
		}

		public int Min
		{
			set
			{
				if (value >= 0 && value <= 60)
				{
					min = value;
				}
				else
				{
					Console.WriteLine("Введите целочисленное значение угла в минутах в диапазоне [0,60]");
					Console.ReadKey();
					Environment.Exit(0);

				}
			}
			get
			{
				return min;
			}
		}
		public int Sec
		{
			set
			{
				if (value >= 0 && value <= 60)
				{
					sec = value;
				}
				else
				{
					Console.WriteLine("Введите целочисленное значение угла в секундах в диапазоне [0,60]");
					Console.ReadKey();
					Environment.Exit(0);
				}
			}
			get
			{
				return sec;
			}
		}

		public Angle()
		{
			Grad = grad;
			Min = min;
			Sec = sec;
		}

		public void GetToRadians()
		{
			double Radian = (grad + (min + (double)sec / 60) / 60) * Math.PI / 180;
			Console.WriteLine("Величина угла в радианах = {0:f7}", Radian);
			Console.ReadKey();
		}

	}
}