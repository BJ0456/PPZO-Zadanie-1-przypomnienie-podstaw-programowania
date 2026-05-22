print("Konwerter temperatur (Celsjusz <-> Fahrenheit)")

skalawpisana = input("Wybierz z jakiej skali chcesz przekonwertować temperature (C Lub F): ")
skala = skalawpisana.lower()

temp = float(input("Podaj wartość temperatury: "))


if skala == "c":
    wynik = temp * 1.8 + 32
    wynik = round(wynik, 1)
    print(f"{temp}° w skali Celsjusza to {wynik}° w skali Fahrenheita")

elif skala == "f":
    wynik = (temp - 32) / 1.8
    wynik = round(wynik, 1)
    print(f"{temp}° w skali Fahrenheita to {wynik}° w skali Celsjusza")

else:
    print("Błędnie wybrano skale, dostępne wybory(C lub F)")
