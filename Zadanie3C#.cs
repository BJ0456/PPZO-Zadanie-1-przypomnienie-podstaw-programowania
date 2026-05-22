using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Średnia ocen ucznia- Kalkulator");
		Console.Write("Podaj liczbę ocen: ");
		int liczbaocen = Convert.ToInt32(Console.ReadLine());
		
		double sumaocen = 0;
		for (int i = 1; i <= liczbaocen; i++){
			Console.Write("Podaj " + i + " ocene (1 - 6):");
			int ocena = Convert.ToInt32(Console.ReadLine());
				if(ocena >= 1 && ocena <=6){
				sumaocen = sumaocen + ocena;
				}else{
					Console.WriteLine("Podano błędną ocene, dostępne oceny to (1-6)");
				}
			}
		
		double sredniaocen = sumaocen / liczbaocen;
		if(sredniaocen >= 3){
			Console.WriteLine("Twoja średnia to " + Math.Round(sredniaocen,1));
			Console.Write("Przedmiot zaliczony!");
		}else{
				Console.WriteLine("Twoja średnia to " + Math.Round(sredniaocen,1));
				Console.Write("Przedmiot niezaliczony");
		}
		


	}
}
