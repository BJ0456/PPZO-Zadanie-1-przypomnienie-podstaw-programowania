print("Program Obliczający")

liczba1 = float(input("Podaj Pierwszą liczbę: "))
liczba2 = float(input("Podaj Drugą liczbę: "))

znak = input("Zdefinuj typ operacji arytmetycznej (+, -, *, /): ")

if znak == "+":
    print(f"Wynik dodawania dwóch liczb to: {liczba1 + liczba2}")
elif znak == "-":
    print(f"Wynik odejmowania dwóch liczb to: {liczba1 - liczba2}")
elif znak == "*":
    print(f"Wynik mnożenia dwóch liczb to: {liczba1 * liczba2}")
elif znak == "/":
    print(f"Wynik dzielenia dwóch liczb to: {liczba1 / liczba2}")
else:
    print("Podano błędny znak arytematyczny!")
