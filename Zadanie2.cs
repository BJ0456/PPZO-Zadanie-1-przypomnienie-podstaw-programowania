using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Konwerter temperatur (Celsjusz ↔ Fahrenheit)");
		Console.Write("Wybierz z jakiej skali chcesz przekonwertować temperature (C Lub F): ");
		string skala = Console.ReadLine().ToLower();
		
		Console.Write("Podaj wartość temperatury: ");
		double temp = Convert.ToDouble(Console.ReadLine());
		
		if(skala == "c"){
			double wynik = Math.Round(temp * 1.8 + 32, 1);	
			Console.Write(temp + "° w skali Celsjusza to " +  wynik + "° w skali Fahrenheita");
		}else if(skala == "f"){
			double wynik = Math.Round((temp - 32) / 1.8, 1);	
			Console.Write(temp + "° w skali Fahrenheita to " +  wynik + "° w skali Celsjusza");
		}else{
			Console.WriteLine("Błędnie wybrano skale, dostępne wybory(C lub F)");	
		}
	}
}
