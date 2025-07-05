import math
from functools import lru_cache

@lru_cache(maxsize=None)
def es_primo(n: int) -> bool:
    """Determina si un número es primo."""
    if n < 2:
        return False
    if n == 2:
        return True
    if n % 2 == 0:
        return False
    raiz = int(math.sqrt(n)) + 1
    for i in range(3, raiz, 2):
        if n % i == 0:
            return False
    return True

def sumar_primos(lista: list[int]) -> int:
    """Suma todos los números primos en la lista."""
    from .validacion import validar_lista_enteros
    validar_lista_enteros(lista)
    return sum(n for n in lista if es_primo(n))
