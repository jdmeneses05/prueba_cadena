# Amazon RDS vs Amazon DynamoDB

##  Comparación General

| Característica         | Amazon RDS                          | Amazon DynamoDB                           |
|------------------------|-------------------------------------|--------------------------------------------|
| Tipo de base de datos  | Relacional (SQL)                    | NoSQL (clave-valor, documento)             |
| Escalabilidad          | Vertical y parcialmente horizontal  | Horizontal automática y sin servidor       |
| Latencia               | Milisegundos                        | Microsegundos / milisegundos               |
| Administración         | Semi-administrada (EC2 detrás)      | Completamente serverless                   |
| Transacciones          | Soporte ACID completo               | Soporte limitado a nivel de ítem           |
| Consultas complejas    | JOIN, subconsultas, funciones SQL   | Clave-partición, rangos, filtros simples   |
| Seguridad              | IAM, KMS, cifrado, VPC              | IAM, KMS, VPC                              |

##  Casos de uso

### Amazon RDS
Usar cuando:
- Se requieren relaciones entre tablas y transacciones ACID fuertes
- Se ejecutan consultas SQL complejas
- Se trabaja con frameworks ORM (Django, .NET, Laravel, etc.)

Ejemplos:
- Sistemas financieros o bancarios
- ERP o CRM con estructuras complejas
- Backend de aplicaciones legacy con SQL tradicional

### Amazon DynamoDB
Usar cuando:
- Se necesita baja latencia en lecturas/escrituras
- Se espera carga variable o muy alta
- Se puede diseñar la base orientada a consultas específicas

Ejemplos:
- Aplicaciones móviles o gaming en tiempo real
- Catálogos de productos o dashboards IoT
- Sistemas de autenticación o sesiones


| Factor                  | DynamoDB                          | RDS                                    |
|-------------------------|-----------------------------------|-----------------------------------------|
| Familiaridad            | Requiere nuevo enfoque mental     | Más tradicional (SQL)                   |
| Costos                  | Escalable por demanda             | Costos fijos según instancia            |
| Modelado de datos       | Basado en patrones de acceso      | Normalizado o relacional                |
| Dev/Prod igualdad       | Fácil de simular con LocalDynamo  | Requiere motor SQL o contenedor         |
