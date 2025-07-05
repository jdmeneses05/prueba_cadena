#  Prueba Técnica – Desarrollador Backend / Cloud (AWS + Algoritmos)

Este repositorio contiene la solución completa a una prueba técnica orientada a evaluar tanto habilidades de desarrollo como conocimientos en servicios de AWS y conceptos DevOps.

---

##  Contenido

| Sección | Descripción |
|--------|-------------|
| `algoritmos/` | Ejercicios de programación con estructura profesional |
| `aws-devops-notes/` | Ejercicios conceptuales y prácticos sobre servicios AWS |
| `documentacion/` | Versión en PDF de toda la prueba, lista para revisión no técnica |

---

##  Parte 1: Ejercicios de Programación

 Carpeta: `PalindromeChecker/PalindromeChecker`

- **Lenguaje**: C#
- **Enunciado**: Verificar si una cadena es un palíndromo (ignorar espacios, signos y mayúsculas)
- **Extras incluidos**:
  - Separación por capas (`Program.cs`, `PalindromeValidator.cs`)
  - Manejo de errores robusto
  - Pruebas unitarias con xUnit
  - Solución estructurada con `.sln` de Visual Studio
  - README adicional para ejecutar

 Carpeta: `CasoPython/suma_primos`

- **Lenguaje**: Python
- **Enunciado**: Sumar todos los números primos en una lista de enteros
- **Extras incluidos**:
  - Código limpio y eficiente
  - Tests con `pytest`
  - Script CLI ejecutable

---

##  Parte 2: AWS y Desarrollo Cloud

 Carpeta: `aws-devops-notes/`

Contiene respuestas técnicas y ejemplos funcionales para 5 temas clave:

1. **RDS vs DynamoDB**  
   Comparativa técnica y casos de uso reales.

2. **AWS Lambda y Serverless**  
   Explicación del modelo y ejemplo funcional (Python + S3).

3. **DevOps en AWS**  
   Concepto, importancia, y uso de CodeCommit, CodeBuild, CodeDeploy, CodePipeline.

4. **Pipeline CI/CD**  
   Explicación paso a paso para desplegar una app con CodePipeline y CodeBuild.

5. **Amazon S3**  
   Casos de uso comunes y ejemplo práctico de subida/descarga de archivos con Boto3.

Todos los archivos están escritos en Markdown, con tablas, código, y comentarios claros. Pueden ser usados como base documental o tutorial técnico.

---

##  Parte 3: Documentación PDF

 Carpeta: `documentacion/`

Incluye la versión PDF de toda la prueba.

Ideal para revisión por parte de líderes no técnicos o reclutadores.

---

##  Cómo ejecutar los ejemplos

###  C# - PalindromeChecker

```bash
cd PalindromeChecker/PalindromeChecker
dotnet test         
dotnet run          
```

###  C# - Python

```bash
cd CasoPython/suma_primos
python -m suma_primos.main 1 2 3 4 5 6 7 8 9 10 # numeros que desee
pytest  
```  