import pytest
from suma_primos.primos import sumar_primos

def test_primos_normales():
    assert sumar_primos([1, 2, 3, 4, 5, 10]) == 10

def test_vacia():
    assert sumar_primos([]) == 0

def test_sin_primos():
    assert sumar_primos([1, 4, 6, 8, 9]) == 0

def test_valor_no_lista():
    with pytest.raises(TypeError):
        sumar_primos("123")

def test_elemento_no_entero():
    with pytest.raises(ValueError):
        sumar_primos([2, "tres", 5])
