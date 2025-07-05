# CI/CD con AWS CodePipeline + CodeBuild

##  ¿Qué es CodePipeline?

**AWS CodePipeline** es un servicio que permite automatizar flujos de integración y entrega continua (CI/CD).  
Orquesta tareas como:

- Obtener código desde una fuente (ej. GitHub, CodeCommit)
- Compilar el proyecto (con CodeBuild)
- Configurar CodePipeline: Establecer las etapas del flujo (fuente, construcción, despliegue)
- Desplegar automáticamente a entornos como S3, ECS, Lambda, etc.

---

##  Componentes principales de un pipeline

1. **Fuente:** Repositorio de código (ej. GitHub, CodeCommit)
2. **Compilación:** Ejecutada con CodeBuild
3. **Despliegue:** Servicios como S3, Lambda, ECS, Elastic Beanstalk, etc.

---


## Ejemplo de `buildspec.yml` para Python

```yaml
version: 0.2

phases:
  install:
    runtime-versions:
      python: 3.10
    commands:
      - pip install -r requirements.txt

  build:
    commands:
      - echo "Ejecutando pruebas..."
      - pytest  # o cualquier otro comando de pruebas

artifacts:
  files:
    - '**/*'
```

---

##  Ejemplo de `buildspec.yml` para C# (.NET Core)

```yaml
version: 0.2

phases:
  install:
    runtime-versions:
      dotnet: 6.0
    commands:
      - echo "Instalando dependencias..."
      - dotnet restore

  build:
    commands:
      - echo "Compilando proyecto..."
      - dotnet build --configuration Release

  post_build:
    commands:
      - echo "Publicando artefactos..."
      - dotnet publish -c Release -o output

artifacts:
  files:
    - '**/*'
  base-directory: output
```
