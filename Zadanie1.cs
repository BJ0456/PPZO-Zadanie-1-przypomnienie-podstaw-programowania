using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Program Obliczający");
		
		Console.Write("Podaj Pierwszą liczbę: ");			
		double liczba1 = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Podaj Drugą liczbę: ");
		double liczba2 = Convert.ToDouble(Console.ReadLine());

		Console.Write("Zdefinuj typ operacji arytmetycznej (+, -, *, /): ");
		string znak = Console.ReadLine();
		
		if(znak == "+"){
			Console.WriteLine("Wynik dodawania dwóch liczb to: " + (liczba1 + liczba2));
		
		}else if(znak == "-"){
			Console.WriteLine("Wynik odejmowania dwóch liczb to: " + (liczba1 - liczba2));
		
		}else if(znak == "*"){
			Console.WriteLine("Wynik mnożenia dwóch liczb to: " + (liczba1 * liczba2));
		
		}else if(znak == "/"){
			Console.WriteLine("Wynik dzielenia dwóch liczb to: " + (liczba1 / liczba2));
		}else{
			Console.WriteLine("Podano błędny znak arytematyczny!");
		};
		
	}
}
