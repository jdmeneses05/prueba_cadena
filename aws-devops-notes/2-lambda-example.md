# AWS Lambda y el enfoque Serverless

## ¿Qué es AWS Lambda?

**AWS Lambda** es un servicio de cómputo serverless que permite ejecutar código sin necesidad de administrar servidores.  
Tú escribes la función, defines el evento que la dispara (por ejemplo, una carga en S3), y Lambda se encarga automáticamente de:

- Ejecutar el código
- Escalar bajo demanda
- Administrar disponibilidad y tolerancia a fallos

---

##  Ventajas del enfoque Serverless

-  **Sin infraestructura que gestionar**
-  **Escalabilidad automática según demanda**
-  **Pago por ejecución** (no por tiempo encendido)
-  **Integración nativa** con servicios como S3, DynamoDB, API Gateway, etc.

---

##  Casos de uso comunes

- Procesamiento de archivos (por ejemplo, generación de miniaturas)
- Automatización de flujos con eventos de base de datos o almacenamiento
- Backends para aplicaciones mediante API Gateway
- Tareas programadas (cron jobs) con Amazon EventBridge (CloudWatch Events)

---

##  Ejemplo práctico: Miniaturas con Lambda + S3

Esta función Lambda se activa automáticamente cada vez que se sube una imagen a un bucket S3.  
Redimensiona la imagen y guarda una miniatura en la carpeta `miniaturas/` dentro del mismo bucket.

```python
import boto3
from PIL import Image
import io

s3 = boto3.client('s3')

def lambda_handler(event, context):
    # Obtener datos del evento
    bucket = event['Records'][0]['s3']['bucket']['name']
    nombre_archivo = event['Records'][0]['s3']['object']['key']
    
    # Descargar la imagen original desde S3
    response = s3.get_object(Bucket=bucket, Key=nombre_archivo)
    imagen_original = Image.open(response['Body'])

    # Redimensionar imagen
    imagen_original.thumbnail((200, 200))  # miniatura de 200x200 px

    # Guardar en buffer y volver a S3
    buffer = io.BytesIO()
    imagen_original.save(buffer, format='JPEG')
    buffer.seek(0)

    s3.put_object(
        Bucket=bucket,
        Key=f"miniaturas/{nombre_archivo}",
        Body=buffer,
        ContentType='image/jpeg'
    )

    return {
        'statusCode': 200,
        'body': f"Miniatura de {nombre_archivo} generada con éxito."
    }
