print("Średnia ocen ucznia- Kalkulator")

liczbaocen = int(input("Podaj liczbę ocen: "))
sumaocen = 0

for i in range(1, liczbaocen + 1):
    ocena = int(input(f"Podaj {i} ocene (1 - 6): "))
    
    if ocena >= 1 and ocena <= 6:
        sumaocen += ocena
    else:
        print("Podano błędną ocene, dostępne oceny to (1-6)")

sredniaocen = sumaocen / liczbaocen

if sredniaocen >= 3:
    print(f"Twoja średnia to {round(sredniaocen, 1)}")
    print("Przedmiot zaliczony!")
else:
    print(f"Twoja średnia to {round(sredniaocen, 1)}")
    print("Przedmiot niezaliczony")
