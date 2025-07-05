import sys
from .primos import sumar_primos

def main():
    try:
        # Convertir argumentos a enteros
        lista = list(map(int, sys.argv[1:]))
        resultado = sumar_primos(lista)
        print(f" Suma de primos: {resultado}")
    except Exception as e:
        print(f" Error: {e}")

if __name__ == "__main__":
    main()
