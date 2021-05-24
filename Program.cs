using System;

namespace Analiza_Collatza
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Podaj liczbę");
			string tekst = Console.ReadLine();
			int liczba = int.Parse(tekst);
			

			while (liczba != 1 )
			{
				if (liczba % 2 == 0)
				{
					 liczba = liczba / 2;
					Console.WriteLine(liczba);
					while (liczba != 1)
					{
						if (liczba % 2 == 0)
						{
							liczba = liczba / 2;
							Console.WriteLine(liczba);
							break;
						}
						else
						{
							liczba = (liczba * 3) + 1;
							Console.WriteLine(liczba);
							break;
						}
					}
				}
				else
				{
					 liczba = (liczba * 3) + 1;
					Console.WriteLine(liczba);
					while (liczba != 1)
					{
						if (liczba % 2 == 0)
						{
							liczba = liczba / 2;
							Console.WriteLine(liczba);
							break;
						}
						else
						{
							liczba = (liczba * 3) + 1;
							Console.WriteLine(liczba);
							break;
						}
					}					
				}
				
			}

			Console.WriteLine("koniec");
		}
	}
}
