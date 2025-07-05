def validar_lista_enteros(lista: list) -> None:
    """Valida que la entrada sea una lista de enteros."""
    if not isinstance(lista, list):
        raise TypeError("Se esperaba una lista como entrada.")
    if not all(isinstance(n, int) for n in lista):
        raise ValueError("Todos los elementos deben ser enteros.")
